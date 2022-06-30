/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "participant", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Participant
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "processRef")]
		public string ProcessRef { get; set; }
	}

	[XmlRoot(ElementName = "messageFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class MessageFlow
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "sourceRef")]
		public string SourceRef { get; set; }
		[XmlAttribute(AttributeName = "targetRef")]
		public string TargetRef { get; set; }
	}

	[XmlRoot(ElementName = "collaboration", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Collaboration
	{
		[XmlElement(ElementName = "participant", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<Participant> Participant { get; set; }
		[XmlElement(ElementName = "messageFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<MessageFlow> MessageFlow { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "lane", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Lane
	{
		[XmlElement(ElementName = "flowNodeRef", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<string> FlowNodeRef { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "laneSet", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class LaneSet
	{
		[XmlElement(ElementName = "lane", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public Lane Lane { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "startEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class StartEvent
	{
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Outgoing { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "task", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Task
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<string> Incoming { get; set; }
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Outgoing { get; set; }
		[XmlAttribute(AttributeName = "completionQuantity")]
		public string CompletionQuantity { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "isForCompensation")]
		public string IsForCompensation { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "startQuantity")]
		public string StartQuantity { get; set; }
	}

	[XmlRoot(ElementName = "exclusiveGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class ExclusiveGateway
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Incoming { get; set; }
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<string> Outgoing { get; set; }
		[XmlAttribute(AttributeName = "gatewayDirection")]
		public string GatewayDirection { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "messageEventDefinition", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class MessageEventDefinition
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "intermediateThrowEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class IntermediateThrowEvent
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Incoming { get; set; }
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Outgoing { get; set; }
		[XmlElement(ElementName = "messageEventDefinition", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public MessageEventDefinition MessageEventDefinition { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "endEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class EndEvent
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<string> Incoming { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "sequenceFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class SequenceFlow
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "sourceRef")]
		public string SourceRef { get; set; }
		[XmlAttribute(AttributeName = "targetRef")]
		public string TargetRef { get; set; }
	}

	[XmlRoot(ElementName = "process", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Process
	{
		[XmlElement(ElementName = "laneSet", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public LaneSet LaneSet { get; set; }
		[XmlElement(ElementName = "startEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public StartEvent StartEvent { get; set; }
		[XmlElement(ElementName = "task", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<Task> Task { get; set; }
		[XmlElement(ElementName = "exclusiveGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<ExclusiveGateway> ExclusiveGateway { get; set; }
		[XmlElement(ElementName = "intermediateThrowEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<IntermediateThrowEvent> IntermediateThrowEvent { get; set; }
		[XmlElement(ElementName = "endEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<EndEvent> EndEvent { get; set; }
		[XmlElement(ElementName = "sequenceFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<SequenceFlow> SequenceFlow { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "isClosed")]
		public string IsClosed { get; set; }
		[XmlAttribute(AttributeName = "isExecutable")]
		public string IsExecutable { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "processType")]
		public string ProcessType { get; set; }
		[XmlElement(ElementName = "intermediateCatchEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<IntermediateCatchEvent> IntermediateCatchEvent { get; set; }
		[XmlElement(ElementName = "eventBasedGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<EventBasedGateway> EventBasedGateway { get; set; }
	}

	[XmlRoot(ElementName = "intermediateCatchEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class IntermediateCatchEvent
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Incoming { get; set; }
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Outgoing { get; set; }
		[XmlElement(ElementName = "messageEventDefinition", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public MessageEventDefinition MessageEventDefinition { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "timerEventDefinition", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public TimerEventDefinition TimerEventDefinition { get; set; }
	}

	[XmlRoot(ElementName = "timeDuration", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class TimeDuration
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "timerEventDefinition", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class TimerEventDefinition
	{
		[XmlElement(ElementName = "timeDuration", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public TimeDuration TimeDuration { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "timeCycle", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public TimeCycle TimeCycle { get; set; }
	}

	[XmlRoot(ElementName = "eventBasedGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class EventBasedGateway
	{
		[XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public string Incoming { get; set; }
		[XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<string> Outgoing { get; set; }
		[XmlAttribute(AttributeName = "eventGatewayType")]
		public string EventGatewayType { get; set; }
		[XmlAttribute(AttributeName = "gatewayDirection")]
		public string GatewayDirection { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "instantiate")]
		public string Instantiate { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "timeCycle", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class TimeCycle
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
	public class Bounds
	{
		[XmlAttribute(AttributeName = "height")]
		public string Height { get; set; }
		[XmlAttribute(AttributeName = "width")]
		public string Width { get; set; }
		[XmlAttribute(AttributeName = "x")]
		public string X { get; set; }
		[XmlAttribute(AttributeName = "y")]
		public string Y { get; set; }
	}

	[XmlRoot(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNLabel
	{
		[XmlElement(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
		public Bounds Bounds { get; set; }
		[XmlAttribute(AttributeName = "labelStyle")]
		public string LabelStyle { get; set; }
	}

	[XmlRoot(ElementName = "BPMNShape", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNShape
	{
		[XmlElement(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
		public Bounds Bounds { get; set; }
		[XmlElement(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public BPMNLabel BPMNLabel { get; set; }
		[XmlAttribute(AttributeName = "bpmnElement")]
		public string BpmnElement { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "isHorizontal")]
		public string IsHorizontal { get; set; }
		[XmlAttribute(AttributeName = "isMarkerVisible")]
		public string IsMarkerVisible { get; set; }
	}

	[XmlRoot(ElementName = "waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
	public class Waypoint
	{
		[XmlAttribute(AttributeName = "x")]
		public string X { get; set; }
		[XmlAttribute(AttributeName = "y")]
		public string Y { get; set; }
	}

	[XmlRoot(ElementName = "BPMNEdge", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNEdge
	{
		[XmlElement(ElementName = "waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
		public List<Waypoint> Waypoint { get; set; }
		[XmlAttribute(AttributeName = "bpmnElement")]
		public string BpmnElement { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public BPMNLabel BPMNLabel { get; set; }
	}

	[XmlRoot(ElementName = "BPMNPlane", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNPlane
	{
		[XmlElement(ElementName = "BPMNShape", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public List<BPMNShape> BPMNShape { get; set; }
		[XmlElement(ElementName = "BPMNEdge", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public List<BPMNEdge> BPMNEdge { get; set; }
		[XmlAttribute(AttributeName = "bpmnElement")]
		public string BpmnElement { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "Font", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
	public class Font
	{
		[XmlAttribute(AttributeName = "isBold")]
		public string IsBold { get; set; }
		[XmlAttribute(AttributeName = "isItalic")]
		public string IsItalic { get; set; }
		[XmlAttribute(AttributeName = "isStrikeThrough")]
		public string IsStrikeThrough { get; set; }
		[XmlAttribute(AttributeName = "isUnderline")]
		public string IsUnderline { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "size")]
		public string Size { get; set; }
	}

	[XmlRoot(ElementName = "BPMNLabelStyle", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNLabelStyle
	{
		[XmlElement(ElementName = "Font", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
		public Font Font { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
	public class BPMNDiagram
	{
		[XmlElement(ElementName = "BPMNPlane", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public BPMNPlane BPMNPlane { get; set; }
		[XmlElement(ElementName = "BPMNLabelStyle", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public List<BPMNLabelStyle> BPMNLabelStyle { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "definitions", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
	public class Definitions
	{
		[XmlElement(ElementName = "collaboration", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public Collaboration Collaboration { get; set; }
		[XmlElement(ElementName = "process", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
		public List<Process> Process { get; set; }
		[XmlElement(ElementName = "BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
		public BPMNDiagram BPMNDiagram { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "bpmndi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Bpmndi { get; set; }
		[XmlAttribute(AttributeName = "omgdc", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Omgdc { get; set; }
		[XmlAttribute(AttributeName = "omgdi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Omgdi { get; set; }
		[XmlAttribute(AttributeName = "signavio", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Signavio { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "exporter")]
		public string Exporter { get; set; }
		[XmlAttribute(AttributeName = "exporterVersion")]
		public string ExporterVersion { get; set; }
		[XmlAttribute(AttributeName = "expressionLanguage")]
		public string ExpressionLanguage { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "targetNamespace")]
		public string TargetNamespace { get; set; }
		[XmlAttribute(AttributeName = "typeLanguage")]
		public string TypeLanguage { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
	}

}