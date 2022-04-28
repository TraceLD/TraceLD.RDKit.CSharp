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

public class PDBWriter : MolWriter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PDBWriter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.PDBWriter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PDBWriter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PDBWriter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_PDBWriter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PDBWriter(string fileName, uint flavor) : this(RDKFuncsPINVOKE.new_PDBWriter__SWIG_0(fileName, flavor), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDBWriter(string fileName) : this(RDKFuncsPINVOKE.new_PDBWriter__SWIG_1(fileName), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDBWriter(SWIGTYPE_p_std__ostream outStream, bool takeOwnership, uint flavor) : this(RDKFuncsPINVOKE.new_PDBWriter__SWIG_2(SWIGTYPE_p_std__ostream.getCPtr(outStream), takeOwnership, flavor), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDBWriter(SWIGTYPE_p_std__ostream outStream, bool takeOwnership) : this(RDKFuncsPINVOKE.new_PDBWriter__SWIG_3(SWIGTYPE_p_std__ostream.getCPtr(outStream), takeOwnership), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDBWriter(SWIGTYPE_p_std__ostream outStream) : this(RDKFuncsPINVOKE.new_PDBWriter__SWIG_4(SWIGTYPE_p_std__ostream.getCPtr(outStream)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void write(ROMol mol, int confId) {
    RDKFuncsPINVOKE.PDBWriter_write__SWIG_0(swigCPtr, ROMol.getCPtr(mol), confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void write(ROMol mol) {
    RDKFuncsPINVOKE.PDBWriter_write__SWIG_1(swigCPtr, ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setProps(Str_Vect arg0) {
    RDKFuncsPINVOKE.PDBWriter_setProps(swigCPtr, Str_Vect.getCPtr(arg0));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void flush() {
    RDKFuncsPINVOKE.PDBWriter_flush(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void close() {
    RDKFuncsPINVOKE.PDBWriter_close(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint numMols() {
    uint ret = RDKFuncsPINVOKE.PDBWriter_numMols(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}