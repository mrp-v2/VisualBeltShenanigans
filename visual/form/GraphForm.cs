using System;
using System.Windows;
using System.Windows.Forms;

using GraphX.Common.Enums;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.Logic.Models;

using VisualBeltShenanigans.code.data.graph;
using VisualBeltShenanigans.code.data.plan;

namespace VisualBeltShenanigans.visual.form
{
	public partial class GraphForm : Form
	{
		public GraphForm(BeltPlan plan)
		{
			InitializeComponent();
			_myPlan = plan;
			Load += Form_Load;
			_layoutAlgorithm = LayoutAlgorithmTypeEnum.Tree;
			_overlapAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
			_edgeAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
		}

		public GraphForm(BeltPlan plan, LayoutAlgorithmTypeEnum layoutAlgorithm) : this(plan)
		{
			_layoutAlgorithm = layoutAlgorithm;
		}

		private void Form_Load(object sender, EventArgs e)
		{
			MyElement.Child = GenerateElementVisuals();
			_graph.GenerateGraph();
			_graph.SetVerticesDrag(true);
			_zoomControl.ZoomToFill();
		}

		private readonly BeltPlan _myPlan;

		private BeltPlanGraph _graph;

		private ZoomControl _zoomControl;

		private readonly LayoutAlgorithmTypeEnum _layoutAlgorithm;
		private readonly OverlapRemovalAlgorithmTypeEnum _overlapAlgorithm;
		private readonly EdgeRoutingAlgorithmTypeEnum _edgeAlgorithm;

		private UIElement GenerateElementVisuals()
		{
			_zoomControl = new ZoomControl();
			ZoomControl.SetViewFinderVisibility(_zoomControl, Visibility.Visible);
			GXLogicCore<Node, BeltPlanGraphEdge, BeltPlanGraphCore> logicCore = new GXLogicCore<Node, BeltPlanGraphEdge, BeltPlanGraphCore>();
			_graph = new BeltPlanGraph
			{
				LogicCore = logicCore,
				EdgeLabelFactory = new DefaultEdgelabelFactory(),
			};
			_graph.ShowAllEdgesLabels(false);
			logicCore.Graph = GenerateGraphCore();
			logicCore.DefaultLayoutAlgorithm = _layoutAlgorithm;
			logicCore.DefaultLayoutAlgorithmParams = logicCore.AlgorithmFactory.CreateLayoutParameters(_layoutAlgorithm);
			logicCore.DefaultOverlapRemovalAlgorithm = _overlapAlgorithm;
			logicCore.DefaultOverlapRemovalAlgorithmParams = logicCore.AlgorithmFactory.CreateOverlapRemovalParameters(_overlapAlgorithm);
			logicCore.DefaultOverlapRemovalAlgorithmParams.HorizontalGap = 50;
			logicCore.DefaultOverlapRemovalAlgorithmParams.VerticalGap = 50;
			logicCore.DefaultEdgeRoutingAlgorithm = _edgeAlgorithm;
			logicCore.DefaultEdgeRoutingAlgorithmParams = logicCore.AlgorithmFactory.CreateEdgeRoutingParameters(_edgeAlgorithm);
			logicCore.AsyncAlgorithmCompute = false;
			_zoomControl.Content = _graph;
			return _zoomControl;
		}

		private BeltPlanGraphCore GenerateGraphCore()
		{
			BeltPlanGraphCore graphCore = new BeltPlanGraphCore();
			foreach (Node n in _myPlan.AssembleVertexes())
			{
				graphCore.AddVertex(n);
			}
			foreach (BeltPlanGraphEdge edge in _myPlan.AssembleEdges())
			{
				graphCore.AddEdge(edge);
			}
			return graphCore;
		}
	}
}
