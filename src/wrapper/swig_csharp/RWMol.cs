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

public class RWMol : ROMol {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal RWMol(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.RWMol_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RWMol obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RWMol() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          RDKFuncsPINVOKE.delete_RWMol(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RWMol() : this(RDKFuncsPINVOKE.new_RWMol__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RWMol(ROMol other, bool quickCopy, int confId) : this(RDKFuncsPINVOKE.new_RWMol__SWIG_1(ROMol.getCPtr(other), quickCopy, confId), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RWMol(ROMol other, bool quickCopy) : this(RDKFuncsPINVOKE.new_RWMol__SWIG_2(ROMol.getCPtr(other), quickCopy), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RWMol(ROMol other) : this(RDKFuncsPINVOKE.new_RWMol__SWIG_3(ROMol.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public RWMol(RWMol other) : this(RDKFuncsPINVOKE.new_RWMol__SWIG_4(RWMol.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insertMol(ROMol other) {
    RDKFuncsPINVOKE.RWMol_insertMol(swigCPtr, ROMol.getCPtr(other));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint addAtom(bool updateLabel) {
    uint ret = RDKFuncsPINVOKE.RWMol_addAtom__SWIG_0(swigCPtr, updateLabel);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addAtom() {
    uint ret = RDKFuncsPINVOKE.RWMol_addAtom__SWIG_1(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addAtom(Atom atom, bool updateLabel) {
    uint ret = RDKFuncsPINVOKE.RWMol_addAtom__SWIG_2(swigCPtr, Atom.getCPtr(atom), updateLabel);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addAtom(Atom atom) {
    uint ret = RDKFuncsPINVOKE.RWMol_addAtom__SWIG_3(swigCPtr, Atom.getCPtr(atom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void replaceAtom(uint idx, Atom atom, bool updateLabel, bool preserveProps) {
    RDKFuncsPINVOKE.RWMol_replaceAtom__SWIG_0(swigCPtr, idx, Atom.getCPtr(atom), updateLabel, preserveProps);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void replaceAtom(uint idx, Atom atom, bool updateLabel) {
    RDKFuncsPINVOKE.RWMol_replaceAtom__SWIG_1(swigCPtr, idx, Atom.getCPtr(atom), updateLabel);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void replaceAtom(uint idx, Atom atom) {
    RDKFuncsPINVOKE.RWMol_replaceAtom__SWIG_2(swigCPtr, idx, Atom.getCPtr(atom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Atom getLastAtom() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_getLastAtom(swigCPtr);
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Atom getActiveAtom() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_getActiveAtom(swigCPtr);
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setActiveAtom(Atom atom) {
    RDKFuncsPINVOKE.RWMol_setActiveAtom__SWIG_0(swigCPtr, Atom.getCPtr(atom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setActiveAtom(uint idx) {
    RDKFuncsPINVOKE.RWMol_setActiveAtom__SWIG_1(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAtom(uint idx) {
    RDKFuncsPINVOKE.RWMol_removeAtom__SWIG_0(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAtom(Atom atom) {
    RDKFuncsPINVOKE.RWMol_removeAtom__SWIG_1(swigCPtr, Atom.getCPtr(atom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint addBond(uint beginAtomIdx, uint endAtomIdx, Bond.BondType order) {
    uint ret = RDKFuncsPINVOKE.RWMol_addBond__SWIG_0(swigCPtr, beginAtomIdx, endAtomIdx, (int)order);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBond(uint beginAtomIdx, uint endAtomIdx) {
    uint ret = RDKFuncsPINVOKE.RWMol_addBond__SWIG_1(swigCPtr, beginAtomIdx, endAtomIdx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBond(Atom beginAtom, Atom endAtom, Bond.BondType order) {
    uint ret = RDKFuncsPINVOKE.RWMol_addBond__SWIG_2(swigCPtr, Atom.getCPtr(beginAtom), Atom.getCPtr(endAtom), (int)order);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBond(Atom beginAtom, Atom endAtom) {
    uint ret = RDKFuncsPINVOKE.RWMol_addBond__SWIG_3(swigCPtr, Atom.getCPtr(beginAtom), Atom.getCPtr(endAtom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBond(Bond bond) {
    uint ret = RDKFuncsPINVOKE.RWMol_addBond__SWIG_4(swigCPtr, Bond.getCPtr(bond));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bond createPartialBond(uint beginAtomIdx, Bond.BondType order) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_createPartialBond__SWIG_0(swigCPtr, beginAtomIdx, (int)order);
    Bond ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bond(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bond createPartialBond(uint beginAtomIdx) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_createPartialBond__SWIG_1(swigCPtr, beginAtomIdx);
    Bond ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bond(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint finishPartialBond(uint endAtomIdx, int bondBookmark, Bond.BondType order) {
    uint ret = RDKFuncsPINVOKE.RWMol_finishPartialBond__SWIG_0(swigCPtr, endAtomIdx, bondBookmark, (int)order);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint finishPartialBond(uint endAtomIdx, int bondBookmark) {
    uint ret = RDKFuncsPINVOKE.RWMol_finishPartialBond__SWIG_1(swigCPtr, endAtomIdx, bondBookmark);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeBond(uint beginAtomIdx, uint endAtomIdx) {
    RDKFuncsPINVOKE.RWMol_removeBond(swigCPtr, beginAtomIdx, endAtomIdx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void replaceBond(uint idx, Bond bond, bool preserveProps, bool keepSGroups) {
    RDKFuncsPINVOKE.RWMol_replaceBond__SWIG_0(swigCPtr, idx, Bond.getCPtr(bond), preserveProps, keepSGroups);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void replaceBond(uint idx, Bond bond, bool preserveProps) {
    RDKFuncsPINVOKE.RWMol_replaceBond__SWIG_1(swigCPtr, idx, Bond.getCPtr(bond), preserveProps);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void replaceBond(uint idx, Bond bond) {
    RDKFuncsPINVOKE.RWMol_replaceBond__SWIG_2(swigCPtr, idx, Bond.getCPtr(bond));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setStereoGroups(StereoGroup_Vect stereo_groups) {
    RDKFuncsPINVOKE.RWMol_setStereoGroups(swigCPtr, StereoGroup_Vect.getCPtr(stereo_groups));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void clear() {
    RDKFuncsPINVOKE.RWMol_clear(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void beginBatchEdit() {
    RDKFuncsPINVOKE.RWMol_beginBatchEdit(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void rollbackBatchEdit() {
    RDKFuncsPINVOKE.RWMol_rollbackBatchEdit(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void commitBatchEdit() {
    RDKFuncsPINVOKE.RWMol_commitBatchEdit(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static RWMol MolFromSmiles(string smi, int debugParse, bool sanitize, String_String_Map replacements) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmiles__SWIG_0(smi, debugParse, sanitize, String_String_Map.getCPtr(replacements));
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmiles(string smi, int debugParse, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmiles__SWIG_1(smi, debugParse, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmiles(string smi, int debugParse) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmiles__SWIG_2(smi, debugParse);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmiles(string smi) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmiles__SWIG_3(smi);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmarts(string sma, int debugParse, bool mergeHs, String_String_Map replacements) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmarts__SWIG_0(sma, debugParse, mergeHs, String_String_Map.getCPtr(replacements));
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmarts(string sma, int debugParse, bool mergeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmarts__SWIG_1(sma, debugParse, mergeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmarts(string sma, int debugParse) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmarts__SWIG_2(sma, debugParse);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSmarts(string sma) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSmarts__SWIG_3(sma);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolBlock(string molB, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolBlock__SWIG_0(molB, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolBlock(string molB, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolBlock__SWIG_1(molB, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolBlock(string molB) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolBlock__SWIG_2(molB);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolFile(string filename, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolFile__SWIG_0(filename, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolFile(string filename, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolFile__SWIG_1(filename, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMolFile(string filename) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMolFile__SWIG_2(filename);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromTPLFile(string fName, bool sanitize, bool skipFirstConf) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromTPLFile__SWIG_0(fName, sanitize, skipFirstConf);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromTPLFile(string fName, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromTPLFile__SWIG_1(fName, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromTPLFile(string fName) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromTPLFile__SWIG_2(fName);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2File(string fName, bool sanitize, bool removeHs, Mol2Type variant, bool cleanupSubstructures) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2File__SWIG_0(fName, sanitize, removeHs, (int)variant, cleanupSubstructures);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2File(string fName, bool sanitize, bool removeHs, Mol2Type variant) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2File__SWIG_1(fName, sanitize, removeHs, (int)variant);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2File(string fName, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2File__SWIG_2(fName, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2File(string fName, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2File__SWIG_3(fName, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2File(string fName) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2File__SWIG_4(fName);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2Block(string molBlock, bool sanitize, bool removeHs, Mol2Type variant, bool cleanupSubstructures) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2Block__SWIG_0(molBlock, sanitize, removeHs, (int)variant, cleanupSubstructures);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2Block(string molBlock, bool sanitize, bool removeHs, Mol2Type variant) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2Block__SWIG_1(molBlock, sanitize, removeHs, (int)variant);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2Block(string molBlock, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2Block__SWIG_2(molBlock, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2Block(string molBlock, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2Block__SWIG_3(molBlock, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromMol2Block(string molBlock) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromMol2Block__SWIG_4(molBlock);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBBlock(string molB, bool sanitize, bool removeHs, uint flavor, bool proximityBonding) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBBlock__SWIG_0(molB, sanitize, removeHs, flavor, proximityBonding);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBBlock(string molB, bool sanitize, bool removeHs, uint flavor) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBBlock__SWIG_1(molB, sanitize, removeHs, flavor);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBBlock(string molB, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBBlock__SWIG_2(molB, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBBlock(string molB, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBBlock__SWIG_3(molB, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBBlock(string molB) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBBlock__SWIG_4(molB);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBFile(string fName, bool sanitize, bool removeHs, uint flavor, bool proximityBonding) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBFile__SWIG_0(fName, sanitize, removeHs, flavor, proximityBonding);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBFile(string fName, bool sanitize, bool removeHs, uint flavor) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBFile__SWIG_1(fName, sanitize, removeHs, flavor);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBFile(string fName, bool sanitize, bool removeHs) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBFile__SWIG_2(fName, sanitize, removeHs);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBFile(string fName, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBFile__SWIG_3(fName, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromPDBFile(string fName) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromPDBFile__SWIG_4(fName);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSequence(string text, bool sanitize, int flavor) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSequence__SWIG_0(text, sanitize, flavor);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSequence(string text, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSequence__SWIG_1(text, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromSequence(string text) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromSequence__SWIG_2(text);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromFASTA(string text, bool sanitize, int flavor) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromFASTA__SWIG_0(text, sanitize, flavor);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromFASTA(string text, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromFASTA__SWIG_1(text, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromFASTA(string text) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromFASTA__SWIG_2(text);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromHELM(string text, bool sanitize) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromHELM__SWIG_0(text, sanitize);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static RWMol MolFromHELM(string text) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.RWMol_MolFromHELM__SWIG_1(text);
    RWMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new RWMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DetectAtomStereoChemistry(Conformer conf) {
    RDKFuncsPINVOKE.RWMol_DetectAtomStereoChemistry(swigCPtr, Conformer.getCPtr(conf));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Kekulize(bool markAtomsBonds, uint maxBackTracks) {
    RDKFuncsPINVOKE.RWMol_Kekulize__SWIG_0(swigCPtr, markAtomsBonds, maxBackTracks);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Kekulize(bool markAtomsBonds) {
    RDKFuncsPINVOKE.RWMol_Kekulize__SWIG_1(swigCPtr, markAtomsBonds);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Kekulize() {
    RDKFuncsPINVOKE.RWMol_Kekulize__SWIG_2(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void sanitizeMol() {
    RDKFuncsPINVOKE.RWMol_sanitizeMol(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
