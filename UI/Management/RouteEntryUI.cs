using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F1 RID: 1777
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x06009EBD RID: 40637 RVA: 0x00285A74 File Offset: 0x00283C74
		// Note: this type is marked as 'beforefieldinit'.
		static RouteEntryUI()
		{
			Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteEntryUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr);
			RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "<AssignedRoute>k__BackingField");
			RouteEntryUI.NativeFieldInfoPtr_SourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "SourceLabel");
			RouteEntryUI.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "DestinationLabel");
			RouteEntryUI.NativeFieldInfoPtr_FilterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "FilterIcon");
			RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "onDeleteClicked");
			RouteEntryUI.NativeFieldInfoPtr_settingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingSource");
			RouteEntryUI.NativeFieldInfoPtr_settingDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingDestination");
			RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682885);
			RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682886);
			RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682887);
			RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682888);
			RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682889);
			RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682890);
			RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682891);
			RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682892);
			RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682893);
			RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682894);
			RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682895);
			RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682896);
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06009EBE RID: 40638 RVA: 0x00285C20 File Offset: 0x00283E20
		// (set) Token: 0x06009EBF RID: 40639 RVA: 0x00285C60 File Offset: 0x00283E60
		public unsafe AdvancedTransitRoute AssignedRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x00285CA4 File Offset: 0x00283EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281642, RefRangeEnd = 281643, XrefRangeStart = 281631, XrefRangeEnd = 281642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRoute(AdvancedTransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x00285CE8 File Offset: 0x00283EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRoute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x00285D1C File Offset: 0x00283F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281643, XrefRangeEnd = 281653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x00285D50 File Offset: 0x00283F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281653, XrefRangeEnd = 281697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SourceClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x00285D84 File Offset: 0x00283F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281697, XrefRangeEnd = 281741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x00285DB8 File Offset: 0x00283FB8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x00285DEC File Offset: 0x00283FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281741, XrefRangeEnd = 281742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x00285E20 File Offset: 0x00284020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281742, XrefRangeEnd = 281750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x00285E88 File Offset: 0x00284088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281750, XrefRangeEnd = 281760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<ITransitEntity> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x00285ECC File Offset: 0x002840CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281760, XrefRangeEnd = 281766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteEntryUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x0004D94B File Offset: 0x0004BB4B
		public RouteEntryUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x00285F08 File Offset: 0x00284108
		// (set) Token: 0x06009ECC RID: 40652 RVA: 0x0004D954 File Offset: 0x0004BB54
		public unsafe AdvancedTransitRoute _AssignedRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x00285F38 File Offset: 0x00284138
		// (set) Token: 0x06009ECE RID: 40654 RVA: 0x0004D973 File Offset: 0x0004BB73
		public unsafe TextMeshProUGUI SourceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x00285F68 File Offset: 0x00284168
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x0004D992 File Offset: 0x0004BB92
		public unsafe TextMeshProUGUI DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x00285F98 File Offset: 0x00284198
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x0004D9B1 File Offset: 0x0004BBB1
		public unsafe Image FilterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x00285FC8 File Offset: 0x002841C8
		// (set) Token: 0x06009ED4 RID: 40660 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
		public unsafe UnityEvent onDeleteClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00285FF8 File Offset: 0x002841F8
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x0004D9EF File Offset: 0x0004BBEF
		public unsafe bool settingSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource)) = value;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x00286020 File Offset: 0x00284220
		// (set) Token: 0x06009ED8 RID: 40664 RVA: 0x0004DA0A File Offset: 0x0004BC0A
		public unsafe bool settingDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination)) = value;
			}
		}

		// Token: 0x04006AA6 RID: 27302
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRoute_k__BackingField;

		// Token: 0x04006AA7 RID: 27303
		private static readonly IntPtr NativeFieldInfoPtr_SourceLabel;

		// Token: 0x04006AA8 RID: 27304
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x04006AA9 RID: 27305
		private static readonly IntPtr NativeFieldInfoPtr_FilterIcon;

		// Token: 0x04006AAA RID: 27306
		private static readonly IntPtr NativeFieldInfoPtr_onDeleteClicked;

		// Token: 0x04006AAB RID: 27307
		private static readonly IntPtr NativeFieldInfoPtr_settingSource;

		// Token: 0x04006AAC RID: 27308
		private static readonly IntPtr NativeFieldInfoPtr_settingDestination;

		// Token: 0x04006AAD RID: 27309
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0;

		// Token: 0x04006AAE RID: 27310
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0;

		// Token: 0x04006AAF RID: 27311
		private static readonly IntPtr NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x04006AB0 RID: 27312
		private static readonly IntPtr NativeMethodInfoPtr_ClearRoute_Public_Void_0;

		// Token: 0x04006AB1 RID: 27313
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Public_Void_0;

		// Token: 0x04006AB2 RID: 27314
		private static readonly IntPtr NativeMethodInfoPtr_SourceClicked_Public_Void_0;

		// Token: 0x04006AB3 RID: 27315
		private static readonly IntPtr NativeMethodInfoPtr_DestinationClicked_Public_Void_0;

		// Token: 0x04006AB4 RID: 27316
		private static readonly IntPtr NativeMethodInfoPtr_FilterClicked_Public_Void_0;

		// Token: 0x04006AB5 RID: 27317
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClicked_Public_Void_0;

		// Token: 0x04006AB6 RID: 27318
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x04006AB7 RID: 27319
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0;

		// Token: 0x04006AB8 RID: 27320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
