using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F5 RID: 1781
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x06009F24 RID: 40740 RVA: 0x00286F5C File Offset: 0x0028515C
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementWorldspaceCanvas()
		{
			Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ManagementWorldspaceCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr);
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "VISIBILITY_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "PROPERTY_CANVAS_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "Canvas");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ScaleCurve");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "TransitRouteVisualsPrefab");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "CrosshairPrompt");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ObjectSelectionLayerMask");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ShownConfigurables");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "OutlinedConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedConfigurables");
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682934);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682935);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682936);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682937);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682938);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682939);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682940);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682941);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682942);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682943);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682944);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682945);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682946);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682947);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682948);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682949);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682950);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682951);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682952);
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009F25 RID: 40741 RVA: 0x00287220 File Offset: 0x00285420
		// (set) Token: 0x06009F26 RID: 40742 RVA: 0x0028725C File Offset: 0x0028545C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009F27 RID: 40743 RVA: 0x0028729C File Offset: 0x0028549C
		public unsafe Property CurrentProperty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 282370, RefRangeEnd = 282374, XrefRangeStart = 282366, XrefRangeEnd = 282370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x002872DC File Offset: 0x002854DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282391, RefRangeEnd = 282393, XrefRangeStart = 282374, XrefRangeEnd = 282391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x00287310 File Offset: 0x00285510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282407, RefRangeEnd = 282409, XrefRangeStart = 282393, XrefRangeEnd = 282407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref preserveSelection;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x00287350 File Offset: 0x00285550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282409, XrefRangeEnd = 282447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x00287384 File Offset: 0x00285584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282485, RefRangeEnd = 282487, XrefRangeStart = 282447, XrefRangeEnd = 282485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x002873B8 File Offset: 0x002855B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282572, RefRangeEnd = 282573, XrefRangeStart = 282487, XrefRangeEnd = 282572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUIs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x002873EC File Offset: 0x002855EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282573, XrefRangeEnd = 282641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x00287420 File Offset: 0x00285620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282657, RefRangeEnd = 282658, XrefRangeStart = 282641, XrefRangeEnd = 282657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x00287454 File Offset: 0x00285654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282658, XrefRangeEnd = 282669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x00287498 File Offset: 0x00285698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282684, RefRangeEnd = 282685, XrefRangeStart = 282669, XrefRangeEnd = 282684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x002874DC File Offset: 0x002856DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282690, RefRangeEnd = 282693, XrefRangeStart = 282685, XrefRangeEnd = 282690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x00287510 File Offset: 0x00285710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282705, RefRangeEnd = 282707, XrefRangeStart = 282693, XrefRangeEnd = 282705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullConfigurables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x00287544 File Offset: 0x00285744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282707, XrefRangeEnd = 282716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConfigurable GetHoveredConfigurable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x00287584 File Offset: 0x00285784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282787, RefRangeEnd = 282788, XrefRangeStart = 282716, XrefRangeEnd = 282787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IConfigurable> GetConfigurablesToShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x002875C4 File Offset: 0x002857C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282795, RefRangeEnd = 282796, XrefRangeStart = 282788, XrefRangeEnd = 282795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCrosshairPrompt(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x00287608 File Offset: 0x00285808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282796, XrefRangeEnd = 282799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCrosshairPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x0028763C File Offset: 0x0028583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282799, XrefRangeEnd = 282814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementWorldspaceCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x0004DCCB File Offset: 0x0004BECB
		public ManagementWorldspaceCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x00287678 File Offset: 0x00285878
		// (set) Token: 0x06009F3A RID: 40762 RVA: 0x0004DCD4 File Offset: 0x0004BED4
		public unsafe static float VISIBILITY_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x00287694 File Offset: 0x00285894
		// (set) Token: 0x06009F3C RID: 40764 RVA: 0x0004DCE2 File Offset: 0x0004BEE2
		public unsafe static float PROPERTY_CANVAS_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x002876B0 File Offset: 0x002858B0
		// (set) Token: 0x06009F3E RID: 40766 RVA: 0x0004DCF0 File Offset: 0x0004BEF0
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x002876D8 File Offset: 0x002858D8
		// (set) Token: 0x06009F40 RID: 40768 RVA: 0x0004DD0B File Offset: 0x0004BF0B
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x00287708 File Offset: 0x00285908
		// (set) Token: 0x06009F42 RID: 40770 RVA: 0x0004DD2A File Offset: 0x0004BF2A
		public unsafe AnimationCurve ScaleCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009F43 RID: 40771 RVA: 0x00287738 File Offset: 0x00285938
		// (set) Token: 0x06009F44 RID: 40772 RVA: 0x0004DD49 File Offset: 0x0004BF49
		public unsafe TransitLineVisuals TransitRouteVisualsPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009F45 RID: 40773 RVA: 0x00287768 File Offset: 0x00285968
		// (set) Token: 0x06009F46 RID: 40774 RVA: 0x0004DD68 File Offset: 0x0004BF68
		public unsafe InputPrompt CrosshairPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009F47 RID: 40775 RVA: 0x00287798 File Offset: 0x00285998
		// (set) Token: 0x06009F48 RID: 40776 RVA: 0x0004DD87 File Offset: 0x0004BF87
		public unsafe LayerMask ObjectSelectionLayerMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask)) = value;
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x002877C0 File Offset: 0x002859C0
		// (set) Token: 0x06009F4A RID: 40778 RVA: 0x0004DDA2 File Offset: 0x0004BFA2
		public unsafe Color HoveredOutlineColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor)) = value;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009F4B RID: 40779 RVA: 0x002877E8 File Offset: 0x002859E8
		// (set) Token: 0x06009F4C RID: 40780 RVA: 0x0004DDBD File Offset: 0x0004BFBD
		public unsafe Color SelectedOutlineColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor)) = value;
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009F4D RID: 40781 RVA: 0x00287810 File Offset: 0x00285A10
		// (set) Token: 0x06009F4E RID: 40782 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
		public unsafe List<IConfigurable> ShownConfigurables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009F4F RID: 40783 RVA: 0x00287840 File Offset: 0x00285A40
		// (set) Token: 0x06009F50 RID: 40784 RVA: 0x0004DDF7 File Offset: 0x0004BFF7
		public unsafe IConfigurable HoveredConfigurable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009F51 RID: 40785 RVA: 0x00287870 File Offset: 0x00285A70
		// (set) Token: 0x06009F52 RID: 40786 RVA: 0x0004DE16 File Offset: 0x0004C016
		public unsafe IConfigurable OutlinedConfigurable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x002878A0 File Offset: 0x00285AA0
		// (set) Token: 0x06009F54 RID: 40788 RVA: 0x0004DE35 File Offset: 0x0004C035
		public unsafe List<IConfigurable> SelectedConfigurables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AE9 RID: 27369
		private static readonly System.IntPtr NativeFieldInfoPtr_VISIBILITY_RANGE;

		// Token: 0x04006AEA RID: 27370
		private static readonly System.IntPtr NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE;

		// Token: 0x04006AEB RID: 27371
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006AEC RID: 27372
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006AED RID: 27373
		private static readonly System.IntPtr NativeFieldInfoPtr_ScaleCurve;

		// Token: 0x04006AEE RID: 27374
		private static readonly System.IntPtr NativeFieldInfoPtr_TransitRouteVisualsPrefab;

		// Token: 0x04006AEF RID: 27375
		private static readonly System.IntPtr NativeFieldInfoPtr_CrosshairPrompt;

		// Token: 0x04006AF0 RID: 27376
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectSelectionLayerMask;

		// Token: 0x04006AF1 RID: 27377
		private static readonly System.IntPtr NativeFieldInfoPtr_HoveredOutlineColor;

		// Token: 0x04006AF2 RID: 27378
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedOutlineColor;

		// Token: 0x04006AF3 RID: 27379
		private static readonly System.IntPtr NativeFieldInfoPtr_ShownConfigurables;

		// Token: 0x04006AF4 RID: 27380
		private static readonly System.IntPtr NativeFieldInfoPtr_HoveredConfigurable;

		// Token: 0x04006AF5 RID: 27381
		private static readonly System.IntPtr NativeFieldInfoPtr_OutlinedConfigurable;

		// Token: 0x04006AF6 RID: 27382
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedConfigurables;

		// Token: 0x04006AF7 RID: 27383
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006AF8 RID: 27384
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006AF9 RID: 27385
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04006AFA RID: 27386
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006AFB RID: 27387
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006AFC RID: 27388
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006AFD RID: 27389
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0;

		// Token: 0x04006AFE RID: 27390
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUIs_Private_Void_0;

		// Token: 0x04006AFF RID: 27391
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006B00 RID: 27392
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006B01 RID: 27393
		private static readonly System.IntPtr NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006B02 RID: 27394
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006B03 RID: 27395
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x04006B04 RID: 27396
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0;

		// Token: 0x04006B05 RID: 27397
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0;

		// Token: 0x04006B06 RID: 27398
		private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0;

		// Token: 0x04006B07 RID: 27399
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0;

		// Token: 0x04006B08 RID: 27400
		private static readonly System.IntPtr NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0;

		// Token: 0x04006B09 RID: 27401
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE4 RID: 3044
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E14F RID: 57679 RVA: 0x00356E34 File Offset: 0x00355034
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9");
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9__24_0");
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682954);
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682955);
			}

			// Token: 0x0600E150 RID: 57680 RVA: 0x00356EB0 File Offset: 0x003550B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E151 RID: 57681 RVA: 0x00356EEC File Offset: 0x003550EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282333, XrefRangeEnd = 282362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LateUpdate_b__24_0(IConfigurable a, IConfigurable b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E152 RID: 57682 RVA: 0x0006D708 File Offset: 0x0006B908
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0600E153 RID: 57683 RVA: 0x00356F4C File Offset: 0x0035514C
			// (set) Token: 0x0600E154 RID: 57684 RVA: 0x0006D711 File Offset: 0x0006B911
			public unsafe static ManagementWorldspaceCanvas.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0600E155 RID: 57685 RVA: 0x00356F74 File Offset: 0x00355174
			// (set) Token: 0x0600E156 RID: 57686 RVA: 0x0006D723 File Offset: 0x0006B923
			public unsafe static Il2CppSystem.Comparison<IConfigurable> __9__24_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<IConfigurable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400971B RID: 38683
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400971C RID: 38684
			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400971D RID: 38685
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400971E RID: 38686
			private static readonly System.IntPtr NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0;
		}

		// Token: 0x02000BE5 RID: 3045
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E157 RID: 57687 RVA: 0x00356F9C File Offset: 0x0035519C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "config");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682956);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682957);
			}

			// Token: 0x0600E158 RID: 57688 RVA: 0x00357018 File Offset: 0x00355218
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E159 RID: 57689 RVA: 0x00357054 File Offset: 0x00355254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282362, XrefRangeEnd = 282366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateUIs_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E15A RID: 57690 RVA: 0x0006D735 File Offset: 0x0006B935
			public __c__DisplayClass23_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458A RID: 17802
			// (get) Token: 0x0600E15B RID: 57691 RVA: 0x00357088 File Offset: 0x00355288
			// (set) Token: 0x0600E15C RID: 57692 RVA: 0x0006D73E File Offset: 0x0006B93E
			public unsafe IConfigurable config
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458B RID: 17803
			// (get) Token: 0x0600E15D RID: 57693 RVA: 0x003570B8 File Offset: 0x003552B8
			// (set) Token: 0x0600E15E RID: 57694 RVA: 0x0006D75D File Offset: 0x0006B95D
			public unsafe ManagementWorldspaceCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400971F RID: 38687
			private static readonly System.IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04009720 RID: 38688
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009721 RID: 38689
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009722 RID: 38690
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0;
		}
	}
}
