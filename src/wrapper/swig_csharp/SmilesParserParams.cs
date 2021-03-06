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

public class SmilesParserParams : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SmilesParserParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SmilesParserParams obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SmilesParserParams() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_SmilesParserParams(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int debugParse {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_debugParse_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = RDKFuncsPINVOKE.SmilesParserParams_debugParse_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool sanitize {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_sanitize_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_sanitize_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public String_String_Map replacements {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_replacements_set(swigCPtr, String_String_Map.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.SmilesParserParams_replacements_get(swigCPtr);
      String_String_Map ret = (cPtr == global::System.IntPtr.Zero) ? null : new String_String_Map(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool allowCXSMILES {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_allowCXSMILES_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_allowCXSMILES_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool strictCXSMILES {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_strictCXSMILES_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_strictCXSMILES_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool parseName {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_parseName_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_parseName_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool removeHs {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_removeHs_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_removeHs_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool useLegacyStereo {
    set {
      RDKFuncsPINVOKE.SmilesParserParams_useLegacyStereo_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.SmilesParserParams_useLegacyStereo_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SmilesParserParams() : this(RDKFuncsPINVOKE.new_SmilesParserParams(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
