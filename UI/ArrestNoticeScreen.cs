using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000677 RID: 1655
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x00261DA0 File Offset: 0x0025FFA0
		// Note: this type is marked as 'beforefieldinit'.
		static ArrestNoticeScreen()
		{
			Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ArrestNoticeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr);
			ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "VEHICLE_POSSESSION_TIMEOUT");
			ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			ArrestNoticeScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "Canvas");
			ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CanvasGroup");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "recordedCrimes");
			ArrestNoticeScreen.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "vehicle");
			ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681550);
			ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681551);
			ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681552);
			ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681553);
			ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681554);
			ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681555);
			ArrestNoticeScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681556);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681557);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681558);
			ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681559);
			ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681560);
			ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681561);
			ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681562);
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x060092AA RID: 37546 RVA: 0x00261F9C File Offset: 0x0026019C
		// (set) Token: 0x060092AB RID: 37547 RVA: 0x00261FD8 File Offset: 0x002601D8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00262018 File Offset: 0x00260218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265408, XrefRangeEnd = 265444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00262054 File Offset: 0x00260254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265444, XrefRangeEnd = 265456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00262088 File Offset: 0x00260288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265456, XrefRangeEnd = 265465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x002620CC File Offset: 0x002602CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265544, RefRangeEnd = 265545, XrefRangeStart = 265465, XrefRangeEnd = 265544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x00262100 File Offset: 0x00260300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265545, XrefRangeEnd = 265553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00262134 File Offset: 0x00260334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265624, RefRangeEnd = 265626, XrefRangeStart = 265553, XrefRangeEnd = 265624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x00262168 File Offset: 0x00260368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265709, RefRangeEnd = 265710, XrefRangeStart = 265626, XrefRangeEnd = 265709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPossession(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref maxStealthLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x002621A8 File Offset: 0x002603A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265761, RefRangeEnd = 265762, XrefRangeStart = 265710, XrefRangeEnd = 265761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref maxStealthLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x002621E8 File Offset: 0x002603E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265762, XrefRangeEnd = 265775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x0026221C File Offset: 0x0026041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265775, XrefRangeEnd = 265785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrestNoticeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x00262258 File Offset: 0x00260458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265785, XrefRangeEnd = 265790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x000468A1 File Offset: 0x00044AA1
		public ArrestNoticeScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x060092B8 RID: 37560 RVA: 0x00262298 File Offset: 0x00260498
		// (set) Token: 0x060092B9 RID: 37561 RVA: 0x000468AA File Offset: 0x00044AAA
		public unsafe static float VEHICLE_POSSESSION_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x060092BA RID: 37562 RVA: 0x002622B4 File Offset: 0x002604B4
		// (set) Token: 0x060092BB RID: 37563 RVA: 0x000468B8 File Offset: 0x00044AB8
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x002622DC File Offset: 0x002604DC
		// (set) Token: 0x060092BD RID: 37565 RVA: 0x000468D3 File Offset: 0x00044AD3
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x0026230C File Offset: 0x0026050C
		// (set) Token: 0x060092BF RID: 37567 RVA: 0x000468F2 File Offset: 0x00044AF2
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x060092C0 RID: 37568 RVA: 0x0026233C File Offset: 0x0026053C
		// (set) Token: 0x060092C1 RID: 37569 RVA: 0x00046911 File Offset: 0x00044B11
		public unsafe RectTransform CrimeEntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x060092C2 RID: 37570 RVA: 0x0026236C File Offset: 0x0026056C
		// (set) Token: 0x060092C3 RID: 37571 RVA: 0x00046930 File Offset: 0x00044B30
		public unsafe RectTransform PenaltyEntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x0026239C File Offset: 0x0026059C
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x0004694F File Offset: 0x00044B4F
		public unsafe RectTransform CrimeEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x002623CC File Offset: 0x002605CC
		// (set) Token: 0x060092C7 RID: 37575 RVA: 0x0004696E File Offset: 0x00044B6E
		public unsafe RectTransform PenaltyEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x060092C8 RID: 37576 RVA: 0x002623FC File Offset: 0x002605FC
		// (set) Token: 0x060092C9 RID: 37577 RVA: 0x0004698D File Offset: 0x00044B8D
		public unsafe Dictionary<Crime, int> recordedCrimes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x060092CA RID: 37578 RVA: 0x0026242C File Offset: 0x0026062C
		// (set) Token: 0x060092CB RID: 37579 RVA: 0x000469AC File Offset: 0x00044BAC
		public unsafe LandVehicle vehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006337 RID: 25399
		private static readonly System.IntPtr NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT;

		// Token: 0x04006338 RID: 25400
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006339 RID: 25401
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400633A RID: 25402
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x0400633B RID: 25403
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeEntryContainer;

		// Token: 0x0400633C RID: 25404
		private static readonly System.IntPtr NativeFieldInfoPtr_PenaltyEntryContainer;

		// Token: 0x0400633D RID: 25405
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeEntryPrefab;

		// Token: 0x0400633E RID: 25406
		private static readonly System.IntPtr NativeFieldInfoPtr_PenaltyEntryPrefab;

		// Token: 0x0400633F RID: 25407
		private static readonly System.IntPtr NativeFieldInfoPtr_recordedCrimes;

		// Token: 0x04006340 RID: 25408
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04006341 RID: 25409
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006342 RID: 25410
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006343 RID: 25411
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006344 RID: 25412
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04006345 RID: 25413
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006346 RID: 25414
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006347 RID: 25415
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006348 RID: 25416
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordCrimes_Public_Void_0;

		// Token: 0x04006349 RID: 25417
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0;

		// Token: 0x0400634A RID: 25418
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0;

		// Token: 0x0400634B RID: 25419
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearEntries_Private_Void_0;

		// Token: 0x0400634C RID: 25420
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400634D RID: 25421
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B88 RID: 2952
		[ObfuscatedName("ScheduleOne.UI.ArrestNoticeScreen+<<Close>g__CloseRoutine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD79 RID: 56697 RVA: 0x0034BE08 File Offset: 0x0034A008
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique()
			{
				Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<<Close>g__CloseRoutine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>1__state");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>2__current");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>4__this");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681563);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681564);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681565);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681566);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681567);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681568);
			}

			// Token: 0x0600DD7A RID: 56698 RVA: 0x0034BF10 File Offset: 0x0034A110
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD7B RID: 56699 RVA: 0x0034BF58 File Offset: 0x0034A158
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD7C RID: 56700 RVA: 0x0034BF8C File Offset: 0x0034A18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265386, XrefRangeEnd = 265403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700445F RID: 17503
			// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x0034BFC8 File Offset: 0x0034A1C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD7E RID: 56702 RVA: 0x0034C008 File Offset: 0x0034A208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265403, XrefRangeEnd = 265408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004460 RID: 17504
			// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x0034C03C File Offset: 0x0034A23C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD80 RID: 56704 RVA: 0x0006B894 File Offset: 0x00069A94
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445A RID: 17498
			// (get) Token: 0x0600DD81 RID: 56705 RVA: 0x0034C07C File Offset: 0x0034A27C
			// (set) Token: 0x0600DD82 RID: 56706 RVA: 0x0006B89D File Offset: 0x00069A9D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700445B RID: 17499
			// (get) Token: 0x0600DD83 RID: 56707 RVA: 0x0034C0A4 File Offset: 0x0034A2A4
			// (set) Token: 0x0600DD84 RID: 56708 RVA: 0x0006B8B8 File Offset: 0x00069AB8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445C RID: 17500
			// (get) Token: 0x0600DD85 RID: 56709 RVA: 0x0034C0D4 File Offset: 0x0034A2D4
			// (set) Token: 0x0600DD86 RID: 56710 RVA: 0x0006B8D7 File Offset: 0x00069AD7
			public unsafe ArrestNoticeScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrestNoticeScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445D RID: 17501
			// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x0034C104 File Offset: 0x0034A304
			// (set) Token: 0x0600DD88 RID: 56712 RVA: 0x0006B8F6 File Offset: 0x00069AF6
			public unsafe float _lerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x1700445E RID: 17502
			// (get) Token: 0x0600DD89 RID: 56713 RVA: 0x0034C12C File Offset: 0x0034A32C
			// (set) Token: 0x0600DD8A RID: 56714 RVA: 0x0006B911 File Offset: 0x00069B11
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040094EC RID: 38124
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094ED RID: 38125
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094EE RID: 38126
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094EF RID: 38127
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x040094F0 RID: 38128
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040094F1 RID: 38129
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094F2 RID: 38130
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F3 RID: 38131
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094F4 RID: 38132
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094F5 RID: 38133
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F6 RID: 38134
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
