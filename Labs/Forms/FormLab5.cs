using Labs.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labs.Forms
{
    public partial class FormLab5 : Form
    {
        public static int weight = 0;
        private readonly Graph graph = new Graph();
        private int vertexsCount = -1;
        private readonly List<GraphVertex> selectedVertexes = new List<GraphVertex>();
        private const int dotSize = 50;
        private readonly int positionDelta;

        public FormLab5()
        {
            InitializeComponent();
            positionDelta = dotSize / 2;
        }

        private void FormLab4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLab4_Load(object sender, EventArgs e)
        {
            var graph = new Graph();
        }

        private void FormLab4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxScreen_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxScreen_MouseClick(object sender, MouseEventArgs e)
        {
            var vertex = graph.FindVertex(new Point(e.X - positionDelta, e.Y - positionDelta));

            if (e.Button == MouseButtons.Left)
            {

                if (vertex != null)
                {
                    graph.RemoveVertex(vertex);
                    if (graph.Vertices.Count == 0)
                        vertexsCount = 0;
                }
                else
                {
                    var vetexName = (++vertexsCount).ToString();
                    graph.AddVertex(vetexName, new Rectangle(e.Location.X - positionDelta, e.Location.Y - positionDelta,
                        dotSize, dotSize));
                }
            }
            else if (vertex != null && e.Button == MouseButtons.Right)
            {
                if (selectedVertexes.Count != 2)
                {
                    vertex.Color = Color.FromArgb(255, 0, 0);
                    selectedVertexes.Add(vertex);
                }

                if(selectedVertexes.Count == 2)
                {
                    new DialogInputForLab5Form().ShowDialog();
                    graph.AddEdge(selectedVertexes[0].Name, selectedVertexes[1].Name, weight);
                    foreach (var vtx in selectedVertexes)
                    {
                        vtx.Color = Color.FromArgb(0, 0, 0);
                    }
                    selectedVertexes.Clear();
                }
            }
            richTextBoxLog.Text = "";
            try
            {
                var dijkstra = new Dijkstra(graph);
                var shortestPath = dijkstra.FindShortestPath("0", vertexsCount.ToString());
                textBoxWeight.Text = dijkstra.EdgesWeightSum.ToString();
                LogFunc($"найкоротший шлях - ({shortestPath})");
            }
            catch
            {
                textBoxWeight.Text = "";
            }
            DrawGrapgh();
        }

        private void DrawGrapgh()
        {
            var bitmap = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);
            var graphics = Graphics.FromImage(bitmap);

            foreach(var vertex in graph.Vertices)
            {
                var vertexBrush = new SolidBrush(vertex.Color);
                var textBrush = new SolidBrush(Color.FromArgb(0, 255, 0));
                var pen = new Pen(Color.FromArgb(0,0,0));

                graphics.FillEllipse(vertexBrush, vertex.Rectangle.X, vertex.Rectangle.Y, 50, 50);

                if (vertex.Name != vertexsCount.ToString())
                    graphics.DrawString(vertex.Name, new Font(FontFamily.GenericSansSerif, 20), textBrush, 
                        (float)vertex.Rectangle.X , (float)vertex.Rectangle.Y);
                else
                    graphics.DrawString("*", new Font(FontFamily.GenericSansSerif, 20), textBrush,
                        (float)vertex.Rectangle.X, (float)vertex.Rectangle.Y);

                foreach (var edge in vertex.Edges)
                {
                    var startPosition = new Point(vertex.Rectangle.X + positionDelta, vertex.Rectangle.Y + positionDelta);
                    var endPosition = new Point(edge.ConnectedVertex.Rectangle.X + positionDelta, 
                        edge.ConnectedVertex.Rectangle.Y + positionDelta);

                    graphics.DrawLine(pen, startPosition, endPosition);

                    graphics.DrawString(edge.EdgeWeight.ToString(), new Font(FontFamily.GenericSansSerif, 20), textBrush,
                    (endPosition.X + startPosition.X) / 2, (endPosition.Y + startPosition.Y) / 2);
                }
            }

            pictureBoxScreen.Image = bitmap;
        }

        void LogFunc(string text, bool underline = false)
        {
            richTextBoxLog.AppendText(text + Environment.NewLine);
            if (underline) richTextBoxLog.AppendText("++++++++++++++++++++++++++++++++++++"
                + Environment.NewLine);
        }
    }
}
