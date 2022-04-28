//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace GraphMolWrap {

public class SparseIntVect32 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SparseIntVect32(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SparseIntVect32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SparseIntVect32() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_SparseIntVect32(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SparseIntVect32() : this(RDKFuncsPINVOKE.new_SparseIntVect32__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect32(int length) : this(RDKFuncsPINVOKE.new_SparseIntVect32__SWIG_1(length), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect32(SparseIntVect32 other) : this(RDKFuncsPINVOKE.new_SparseIntVect32__SWIG_2(SparseIntVect32.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect32(string pkl) : this(RDKFuncsPINVOKE.new_SparseIntVect32__SWIG_3(pkl), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect32(string pkl, uint len) : this(RDKFuncsPINVOKE.new_SparseIntVect32__SWIG_4(pkl, len), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getVal(int idx) {
    int ret = RDKFuncsPINVOKE.SparseIntVect32_getVal(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVal(int idx, int val) {
    RDKFuncsPINVOKE.SparseIntVect32_setVal(swigCPtr, idx, val);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getLength() {
    int ret = RDKFuncsPINVOKE.SparseIntVect32_getLength(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTotalVal(bool doAbs) {
    int ret = RDKFuncsPINVOKE.SparseIntVect32_getTotalVal__SWIG_0(swigCPtr, doAbs);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTotalVal() {
    int ret = RDKFuncsPINVOKE.SparseIntVect32_getTotalVal__SWIG_1(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = RDKFuncsPINVOKE.SparseIntVect32_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Int_Int_Map getNonzeroElements() {
    Int_Int_Map ret = new Int_Int_Map(RDKFuncsPINVOKE.SparseIntVect32_getNonzeroElements(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(SparseIntVect32 v2) {
    bool ret = RDKFuncsPINVOKE.SparseIntVect32_eq(swigCPtr, SparseIntVect32.getCPtr(v2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(SparseIntVect32 v2) {
    bool ret = RDKFuncsPINVOKE.SparseIntVect32_ne(swigCPtr, SparseIntVect32.getCPtr(v2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string toString() {
    string ret = RDKFuncsPINVOKE.SparseIntVect32_toString(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void fromString(string txt) {
    RDKFuncsPINVOKE.SparseIntVect32_fromString(swigCPtr, txt);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Match_Vect getNonzero() {
    Match_Vect ret = new Match_Vect(RDKFuncsPINVOKE.SparseIntVect32_getNonzero(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}