// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/proto/map_parking_space.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Hdmap {

  /// <summary>Holder for reflection information generated from modules/map/proto/map_parking_space.proto</summary>
  public static partial class MapParkingSpaceReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/proto/map_parking_space.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapParkingSpaceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciltb2R1bGVzL21hcC9wcm90by9tYXBfcGFya2luZ19zcGFjZS5wcm90bxIM",
            "YXBvbGxvLmhkbWFwGiRtb2R1bGVzL21hcC9wcm90by9tYXBfZ2VvbWV0cnku",
            "cHJvdG8aHm1vZHVsZXMvbWFwL3Byb3RvL21hcF9pZC5wcm90byKLAQoMUGFy",
            "a2luZ1NwYWNlEhwKAmlkGAEgASgLMhAuYXBvbGxvLmhkbWFwLklkEiYKB3Bv",
            "bHlnb24YAiABKAsyFS5hcG9sbG8uaGRtYXAuUG9seWdvbhIkCgpvdmVybGFw",
            "X2lkGAMgAygLMhAuYXBvbGxvLmhkbWFwLklkEg8KB2hlYWRpbmcYBCABKAEi",
            "eAoKUGFya2luZ0xvdBIcCgJpZBgBIAEoCzIQLmFwb2xsby5oZG1hcC5JZBIm",
            "Cgdwb2x5Z29uGAIgASgLMhUuYXBvbGxvLmhkbWFwLlBvbHlnb24SJAoKb3Zl",
            "cmxhcF9pZBgDIAMoCzIQLmFwb2xsby5oZG1hcC5JZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Hdmap.MapGeometryReflection.Descriptor, global::Apollo.Hdmap.MapIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.ParkingSpace), global::Apollo.Hdmap.ParkingSpace.Parser, new[]{ "Id", "Polygon", "OverlapId", "Heading" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.ParkingLot), global::Apollo.Hdmap.ParkingLot.Parser, new[]{ "Id", "Polygon", "OverlapId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// ParkingSpace is a place designated to park a car.
  /// </summary>
  public sealed partial class ParkingSpace : pb::IMessage<ParkingSpace> {
    private static readonly pb::MessageParser<ParkingSpace> _parser = new pb::MessageParser<ParkingSpace>(() => new ParkingSpace());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParkingSpace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapParkingSpaceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingSpace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingSpace(ParkingSpace other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      Polygon = other.polygon_ != null ? other.Polygon.Clone() : null;
      overlapId_ = other.overlapId_.Clone();
      heading_ = other.heading_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingSpace Clone() {
      return new ParkingSpace(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::Apollo.Hdmap.Id id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Id Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "polygon" field.</summary>
    public const int PolygonFieldNumber = 2;
    private global::Apollo.Hdmap.Polygon polygon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Polygon Polygon {
      get { return polygon_; }
      set {
        polygon_ = value;
      }
    }

    /// <summary>Field number for the "overlap_id" field.</summary>
    public const int OverlapIdFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Id> _repeated_overlapId_codec
        = pb::FieldCodec.ForMessage(26, global::Apollo.Hdmap.Id.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Id> overlapId_ = new pbc::RepeatedField<global::Apollo.Hdmap.Id>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Id> OverlapId {
      get { return overlapId_; }
    }

    /// <summary>Field number for the "heading" field.</summary>
    public const int HeadingFieldNumber = 4;
    private double heading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Heading {
      get { return heading_; }
      set {
        heading_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParkingSpace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParkingSpace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (!object.Equals(Polygon, other.Polygon)) return false;
      if(!overlapId_.Equals(other.overlapId_)) return false;
      if (Heading != other.Heading) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (polygon_ != null) hash ^= Polygon.GetHashCode();
      hash ^= overlapId_.GetHashCode();
      if (Heading != 0D) hash ^= Heading.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (polygon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Polygon);
      }
      overlapId_.WriteTo(output, _repeated_overlapId_codec);
      if (Heading != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Heading);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (polygon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Polygon);
      }
      size += overlapId_.CalculateSize(_repeated_overlapId_codec);
      if (Heading != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParkingSpace other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.polygon_ != null) {
        if (polygon_ == null) {
          polygon_ = new global::Apollo.Hdmap.Polygon();
        }
        Polygon.MergeFrom(other.Polygon);
      }
      overlapId_.Add(other.overlapId_);
      if (other.Heading != 0D) {
        Heading = other.Heading;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (id_ == null) {
              id_ = new global::Apollo.Hdmap.Id();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            if (polygon_ == null) {
              polygon_ = new global::Apollo.Hdmap.Polygon();
            }
            input.ReadMessage(polygon_);
            break;
          }
          case 26: {
            overlapId_.AddEntriesFrom(input, _repeated_overlapId_codec);
            break;
          }
          case 33: {
            Heading = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// ParkingLot is a place for parking cars.
  /// </summary>
  public sealed partial class ParkingLot : pb::IMessage<ParkingLot> {
    private static readonly pb::MessageParser<ParkingLot> _parser = new pb::MessageParser<ParkingLot>(() => new ParkingLot());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParkingLot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapParkingSpaceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingLot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingLot(ParkingLot other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      Polygon = other.polygon_ != null ? other.Polygon.Clone() : null;
      overlapId_ = other.overlapId_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParkingLot Clone() {
      return new ParkingLot(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::Apollo.Hdmap.Id id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Id Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "polygon" field.</summary>
    public const int PolygonFieldNumber = 2;
    private global::Apollo.Hdmap.Polygon polygon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Polygon Polygon {
      get { return polygon_; }
      set {
        polygon_ = value;
      }
    }

    /// <summary>Field number for the "overlap_id" field.</summary>
    public const int OverlapIdFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Id> _repeated_overlapId_codec
        = pb::FieldCodec.ForMessage(26, global::Apollo.Hdmap.Id.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Id> overlapId_ = new pbc::RepeatedField<global::Apollo.Hdmap.Id>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Id> OverlapId {
      get { return overlapId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParkingLot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParkingLot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (!object.Equals(Polygon, other.Polygon)) return false;
      if(!overlapId_.Equals(other.overlapId_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (polygon_ != null) hash ^= Polygon.GetHashCode();
      hash ^= overlapId_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (polygon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Polygon);
      }
      overlapId_.WriteTo(output, _repeated_overlapId_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (polygon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Polygon);
      }
      size += overlapId_.CalculateSize(_repeated_overlapId_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParkingLot other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.polygon_ != null) {
        if (polygon_ == null) {
          polygon_ = new global::Apollo.Hdmap.Polygon();
        }
        Polygon.MergeFrom(other.Polygon);
      }
      overlapId_.Add(other.overlapId_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (id_ == null) {
              id_ = new global::Apollo.Hdmap.Id();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            if (polygon_ == null) {
              polygon_ = new global::Apollo.Hdmap.Polygon();
            }
            input.ReadMessage(polygon_);
            break;
          }
          case 26: {
            overlapId_.AddEntriesFrom(input, _repeated_overlapId_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
