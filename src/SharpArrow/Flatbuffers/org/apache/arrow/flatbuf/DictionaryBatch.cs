// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace org.apache.arrow.flatbuf
{

using global::System;
using global::FlatBuffers;

/// For sending dictionary encoding information. Any Field can be
/// dictionary-encoded, but in this case none of its children may be
/// dictionary-encoded.
/// There is one vector / column per dictionary, but that vector / column
/// may be spread across multiple dictionary batches by using the isDelta
/// flag
public struct DictionaryBatch : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DictionaryBatch GetRootAsDictionaryBatch(ByteBuffer _bb) { return GetRootAsDictionaryBatch(_bb, new DictionaryBatch()); }
  public static DictionaryBatch GetRootAsDictionaryBatch(ByteBuffer _bb, DictionaryBatch obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DictionaryBatch __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public RecordBatch? Data { get { int o = __p.__offset(6); return o != 0 ? (RecordBatch?)(new RecordBatch()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  /// If isDelta is true the values in the dictionary are to be appended to a
  /// dictionary with the indicated id
  public bool IsDelta { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<DictionaryBatch> CreateDictionaryBatch(FlatBufferBuilder builder,
      long id = 0,
      Offset<RecordBatch> dataOffset = default(Offset<RecordBatch>),
      bool isDelta = false) {
    builder.StartObject(3);
    DictionaryBatch.AddId(builder, id);
    DictionaryBatch.AddData(builder, dataOffset);
    DictionaryBatch.AddIsDelta(builder, isDelta);
    return DictionaryBatch.EndDictionaryBatch(builder);
  }

  public static void StartDictionaryBatch(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddData(FlatBufferBuilder builder, Offset<RecordBatch> dataOffset) { builder.AddOffset(1, dataOffset.Value, 0); }
  public static void AddIsDelta(FlatBufferBuilder builder, bool isDelta) { builder.AddBool(2, isDelta, false); }
  public static Offset<DictionaryBatch> EndDictionaryBatch(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DictionaryBatch>(o);
  }
};


}
