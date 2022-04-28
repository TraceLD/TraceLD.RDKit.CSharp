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

public class StringRect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StringRect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringRect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringRect() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_StringRect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Point2D trans_ {
    set {
      RDKFuncsPINVOKE.StringRect_trans__set(swigCPtr, Point2D.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.StringRect_trans__get(swigCPtr);
      Point2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new Point2D(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Point2D offset_ {
    set {
      RDKFuncsPINVOKE.StringRect_offset__set(swigCPtr, Point2D.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.StringRect_offset__get(swigCPtr);
      Point2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new Point2D(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Point2D g_centre_ {
    set {
      RDKFuncsPINVOKE.StringRect_g_centre__set(swigCPtr, Point2D.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.StringRect_g_centre__get(swigCPtr);
      Point2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new Point2D(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double y_shift_ {
    set {
      RDKFuncsPINVOKE.StringRect_y_shift__set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.StringRect_y_shift__get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double width_ {
    set {
      RDKFuncsPINVOKE.StringRect_width__set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.StringRect_width__get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double height_ {
    set {
      RDKFuncsPINVOKE.StringRect_height__set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.StringRect_height__get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double rect_corr_ {
    set {
      RDKFuncsPINVOKE.StringRect_rect_corr__set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.StringRect_rect_corr__get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int clash_score_ {
    set {
      RDKFuncsPINVOKE.StringRect_clash_score__set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = RDKFuncsPINVOKE.StringRect_clash_score__get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public StringRect() : this(RDKFuncsPINVOKE.new_StringRect__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringRect(Point2D offset, Point2D g_centre, double w, double h) : this(RDKFuncsPINVOKE.new_StringRect__SWIG_1(Point2D.getCPtr(offset), Point2D.getCPtr(g_centre), w, h), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calcCorners(Point2D tl, Point2D tr, Point2D br, Point2D bl, double padding) {
    RDKFuncsPINVOKE.StringRect_calcCorners(swigCPtr, Point2D.getCPtr(tl), Point2D.getCPtr(tr), Point2D.getCPtr(br), Point2D.getCPtr(bl), padding);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool doesItIntersect(StringRect other) {
    bool ret = RDKFuncsPINVOKE.StringRect_doesItIntersect(swigCPtr, StringRect.getCPtr(other));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}