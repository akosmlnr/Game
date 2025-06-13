using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Relations
{
	// Token: 0x020006BE RID: 1726
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x0600988B RID: 39051 RVA: 0x002739C0 File Offset: 0x00271BC0
		// Note: this type is marked as 'beforefieldinit'.
		static RelationCircle()
		{
			Il2CppClassPointerStore<RelationCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Relations", "RelationCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr);
			RelationCircle.NativeFieldInfoPtr_NotchMinRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMinRot");
			RelationCircle.NativeFieldInfoPtr_NotchMaxRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMaxRot");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_ZeroDependence");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_MaxDependence");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC_ID");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC");
			RelationCircle.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onClicked");
			RelationCircle.NativeFieldInfoPtr_onHoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverStart");
			RelationCircle.NativeFieldInfoPtr_onHoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverEnd");
			RelationCircle.NativeFieldInfoPtr_AutoSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AutoSetName");
			RelationCircle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Rect");
			RelationCircle.NativeFieldInfoPtr_PortraitBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitBackground");
			RelationCircle.NativeFieldInfoPtr_HeadshotImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "HeadshotImg");
			RelationCircle.NativeFieldInfoPtr_NotchPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchPivot");
			RelationCircle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Locked");
			RelationCircle.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Button");
			RelationCircle.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Trigger");
			RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682253);
			RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682254);
			RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682255);
			RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682256);
			RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682257);
			RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682258);
			RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682259);
			RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682260);
			RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682261);
			RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682262);
			RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682263);
			RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682264);
			RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682265);
			RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682266);
			RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682267);
			RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682268);
			RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682269);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682271);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682272);
			RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100682273);
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00273CD4 File Offset: 0x00271ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273422, XrefRangeEnd = 273484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x00273D08 File Offset: 0x00271F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273484, XrefRangeEnd = 273495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x00273D3C File Offset: 0x00271F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273575, RefRangeEnd = 273577, XrefRangeStart = 273495, XrefRangeEnd = 273575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x00273D80 File Offset: 0x00271F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273607, RefRangeEnd = 273608, XrefRangeStart = 273577, XrefRangeEnd = 273607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x00273DB4 File Offset: 0x00271FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273608, XrefRangeEnd = 273609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x00273DF4 File Offset: 0x00271FF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273612, RefRangeEnd = 273615, XrefRangeStart = 273609, XrefRangeEnd = 273612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotchPosition(float relationshipDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref relationshipDelta;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x00273E34 File Offset: 0x00272034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273618, RefRangeEnd = 273620, XrefRangeStart = 273615, XrefRangeEnd = 273618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotchPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x00273E68 File Offset: 0x00272068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273637, RefRangeEnd = 273638, XrefRangeStart = 273620, XrefRangeEnd = 273637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDependenceDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x00273E9C File Offset: 0x0027209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273638, XrefRangeEnd = 273643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x00273ED0 File Offset: 0x002720D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273647, RefRangeEnd = 273648, XrefRangeStart = 273643, XrefRangeEnd = 273647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x00273F1C File Offset: 0x0027211C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273653, RefRangeEnd = 273654, XrefRangeStart = 273648, XrefRangeEnd = 273653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x00273F50 File Offset: 0x00272150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273673, RefRangeEnd = 273675, XrefRangeStart = 273654, XrefRangeEnd = 273673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlackout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x00273F84 File Offset: 0x00272184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273676, RefRangeEnd = 273677, XrefRangeStart = 273675, XrefRangeEnd = 273676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackedOut(bool blackedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref blackedOut;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x00273FC4 File Offset: 0x002721C4
		[CallerCount(0)]
		public unsafe void ButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x00273FF8 File Offset: 0x002721F8
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x0027402C File Offset: 0x0027222C
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x00274060 File Offset: 0x00272260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273677, XrefRangeEnd = 273681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x0027409C File Offset: 0x0027229C
		[CallerCount(0)]
		public unsafe void _Awake_b__17_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x002740E0 File Offset: 0x002722E0
		[CallerCount(0)]
		public unsafe void _Awake_b__17_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x00274124 File Offset: 0x00272324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273681, XrefRangeEnd = 273682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AssignNPC_b__19_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref <p1>;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x00049C33 File Offset: 0x00047E33
		public RelationCircle(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x00274170 File Offset: 0x00272370
		// (set) Token: 0x060098A2 RID: 39074 RVA: 0x00049C3C File Offset: 0x00047E3C
		public unsafe static float NotchMinRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&value));
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x060098A3 RID: 39075 RVA: 0x0027418C File Offset: 0x0027238C
		// (set) Token: 0x060098A4 RID: 39076 RVA: 0x00049C4A File Offset: 0x00047E4A
		public unsafe static float NotchMaxRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&value));
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x060098A5 RID: 39077 RVA: 0x002741A8 File Offset: 0x002723A8
		// (set) Token: 0x060098A6 RID: 39078 RVA: 0x00049C58 File Offset: 0x00047E58
		public unsafe static Color PortraitColor_ZeroDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x002741C4 File Offset: 0x002723C4
		// (set) Token: 0x060098A8 RID: 39080 RVA: 0x00049C66 File Offset: 0x00047E66
		public unsafe static Color PortraitColor_MaxDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x060098A9 RID: 39081 RVA: 0x002741E0 File Offset: 0x002723E0
		// (set) Token: 0x060098AA RID: 39082 RVA: 0x00049C74 File Offset: 0x00047E74
		public unsafe string AssignedNPC_ID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x060098AB RID: 39083 RVA: 0x00274208 File Offset: 0x00272408
		// (set) Token: 0x060098AC RID: 39084 RVA: 0x00049C93 File Offset: 0x00047E93
		public unsafe NPC AssignedNPC
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x00274238 File Offset: 0x00272438
		// (set) Token: 0x060098AE RID: 39086 RVA: 0x00049CB2 File Offset: 0x00047EB2
		public unsafe Il2CppSystem.Action onClicked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x060098AF RID: 39087 RVA: 0x00274268 File Offset: 0x00272468
		// (set) Token: 0x060098B0 RID: 39088 RVA: 0x00049CD1 File Offset: 0x00047ED1
		public unsafe Il2CppSystem.Action onHoverStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x00274298 File Offset: 0x00272498
		// (set) Token: 0x060098B2 RID: 39090 RVA: 0x00049CF0 File Offset: 0x00047EF0
		public unsafe Il2CppSystem.Action onHoverEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x060098B3 RID: 39091 RVA: 0x002742C8 File Offset: 0x002724C8
		// (set) Token: 0x060098B4 RID: 39092 RVA: 0x00049D0F File Offset: 0x00047F0F
		public unsafe bool AutoSetName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName)) = value;
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x002742F0 File Offset: 0x002724F0
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x00049D2A File Offset: 0x00047F2A
		public unsafe RectTransform Rect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x060098B7 RID: 39095 RVA: 0x00274320 File Offset: 0x00272520
		// (set) Token: 0x060098B8 RID: 39096 RVA: 0x00049D49 File Offset: 0x00047F49
		public unsafe Image PortraitBackground
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x060098B9 RID: 39097 RVA: 0x00274350 File Offset: 0x00272550
		// (set) Token: 0x060098BA RID: 39098 RVA: 0x00049D68 File Offset: 0x00047F68
		public unsafe Image HeadshotImg
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x060098BB RID: 39099 RVA: 0x00274380 File Offset: 0x00272580
		// (set) Token: 0x060098BC RID: 39100 RVA: 0x00049D87 File Offset: 0x00047F87
		public unsafe RectTransform NotchPivot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x002743B0 File Offset: 0x002725B0
		// (set) Token: 0x060098BE RID: 39102 RVA: 0x00049DA6 File Offset: 0x00047FA6
		public unsafe RectTransform Locked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x060098BF RID: 39103 RVA: 0x002743E0 File Offset: 0x002725E0
		// (set) Token: 0x060098C0 RID: 39104 RVA: 0x00049DC5 File Offset: 0x00047FC5
		public unsafe Button Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x060098C1 RID: 39105 RVA: 0x00274410 File Offset: 0x00272610
		// (set) Token: 0x060098C2 RID: 39106 RVA: 0x00049DE4 File Offset: 0x00047FE4
		public unsafe EventTrigger Trigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066DE RID: 26334
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchMinRot;

		// Token: 0x040066DF RID: 26335
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchMaxRot;

		// Token: 0x040066E0 RID: 26336
		private static readonly System.IntPtr NativeFieldInfoPtr_PortraitColor_ZeroDependence;

		// Token: 0x040066E1 RID: 26337
		private static readonly System.IntPtr NativeFieldInfoPtr_PortraitColor_MaxDependence;

		// Token: 0x040066E2 RID: 26338
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedNPC_ID;

		// Token: 0x040066E3 RID: 26339
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedNPC;

		// Token: 0x040066E4 RID: 26340
		private static readonly System.IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x040066E5 RID: 26341
		private static readonly System.IntPtr NativeFieldInfoPtr_onHoverStart;

		// Token: 0x040066E6 RID: 26342
		private static readonly System.IntPtr NativeFieldInfoPtr_onHoverEnd;

		// Token: 0x040066E7 RID: 26343
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoSetName;

		// Token: 0x040066E8 RID: 26344
		private static readonly System.IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040066E9 RID: 26345
		private static readonly System.IntPtr NativeFieldInfoPtr_PortraitBackground;

		// Token: 0x040066EA RID: 26346
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadshotImg;

		// Token: 0x040066EB RID: 26347
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchPivot;

		// Token: 0x040066EC RID: 26348
		private static readonly System.IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x040066ED RID: 26349
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040066EE RID: 26350
		private static readonly System.IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x040066EF RID: 26351
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040066F0 RID: 26352
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040066F1 RID: 26353
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0;

		// Token: 0x040066F2 RID: 26354
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignNPC_Private_Void_0;

		// Token: 0x040066F3 RID: 26355
		private static readonly System.IntPtr NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0;

		// Token: 0x040066F4 RID: 26356
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0;

		// Token: 0x040066F5 RID: 26357
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0;

		// Token: 0x040066F6 RID: 26358
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0;

		// Token: 0x040066F7 RID: 26359
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_0;

		// Token: 0x040066F8 RID: 26360
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0;

		// Token: 0x040066F9 RID: 26361
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadNPCData_Public_Void_0;

		// Token: 0x040066FA RID: 26362
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBlackout_Private_Void_0;

		// Token: 0x040066FB RID: 26363
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0;

		// Token: 0x040066FC RID: 26364
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

		// Token: 0x040066FD RID: 26365
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x040066FE RID: 26366
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x040066FF RID: 26367
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006700 RID: 26368
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0;

		// Token: 0x04006701 RID: 26369
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0;

		// Token: 0x04006702 RID: 26370
		private static readonly System.IntPtr NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0;
	}
}
