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

public class RGroupDecomposition : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RGroupDecomposition(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RGroupDecomposition obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RGroupDecomposition() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_RGroupDecomposition(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RGroupDecomposition(ROMol core, RGroupDecompositionParameters arg1) : this(RDKFuncsPINVOKE.new_RGroupDecomposition__SWIG_0(ROMol.getCPtr(core), RGroupDecompositionParameters.getCPtr(arg1)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGroupDecomposition(ROMol core) : this(RDKFuncsPINVOKE.new_RGroupDecomposition__SWIG_1(ROMol.getCPtr(core)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGroupDecomposition(ROMol_Vect cores, RGroupDecompositionParameters arg1) : this(RDKFuncsPINVOKE.new_RGroupDecomposition__SWIG_2(ROMol_Vect.getCPtr(cores), RGroupDecompositionParameters.getCPtr(arg1)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGroupDecomposition(ROMol_Vect cores) : this(RDKFuncsPINVOKE.new_RGroupDecomposition__SWIG_3(ROMol_Vect.getCPtr(cores)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int add(ROMol mol) {
    int ret = RDKFuncsPINVOKE.RGroupDecomposition_add(swigCPtr, ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGroupDecompositionProcessResult processAndScore() {
    RGroupDecompositionProcessResult ret = new RGroupDecompositionProcessResult(RDKFuncsPINVOKE.RGroupDecomposition_processAndScore(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool process() {
    bool ret = RDKFuncsPINVOKE.RGroupDecomposition_process(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGroupDecompositionParameters params_() {
    RGroupDecompositionParameters ret = new RGroupDecompositionParameters(RDKFuncsPINVOKE.RGroupDecomposition_params_(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Str_Vect getRGroupLabels() {
    Str_Vect ret = new Str_Vect(RDKFuncsPINVOKE.RGroupDecomposition_getRGroupLabels(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringMolMap_Vect getRGroupsAsRows() {
    StringMolMap_Vect ret = new StringMolMap_Vect(RDKFuncsPINVOKE.RGroupDecomposition_getRGroupsAsRows(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringROMol_VectMap getRGroupsAsColumns() {
    StringROMol_VectMap ret = new StringROMol_VectMap(RDKFuncsPINVOKE.RGroupDecomposition_getRGroupsAsColumns(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
