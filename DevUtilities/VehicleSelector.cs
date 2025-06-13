using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000490 RID: 1168
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		// Token: 0x06006415 RID: 25621 RVA: 0x001C93C4 File Offset: 0x001C75C4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSelector()
		{
			Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr);
			VehicleSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionRange");
			VehicleSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionMask");
			VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			VehicleSelector.NativeFieldInfoPtr_selectedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectedVehicles");
			VehicleSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "onClose");
			VehicleSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectionLimit");
			VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "exitOnSelectionLimit");
			VehicleSelector.NativeFieldInfoPtr_hoveredVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "hoveredVehicle");
			VehicleSelector.NativeFieldInfoPtr_outlinedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "outlinedVehicles");
			VehicleSelector.NativeFieldInfoPtr_vehicleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "vehicleFilter");
			VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676098);
			VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676099);
			VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676100);
			VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676101);
			VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676102);
			VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676103);
			VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676104);
			VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676105);
			VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676106);
			VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100676107);
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x001C9584 File Offset: 0x001C7784
		// (set) Token: 0x06006417 RID: 25623 RVA: 0x001C95C0 File Offset: 0x001C77C0
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x001C9600 File Offset: 0x001C7800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206359, XrefRangeEnd = 206372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x001C963C File Offset: 0x001C783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206372, XrefRangeEnd = 206412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x001C9678 File Offset: 0x001C7878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206412, XrefRangeEnd = 206441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x001C96B4 File Offset: 0x001C78B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206441, XrefRangeEnd = 206454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetHoveredVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x001C96F4 File Offset: 0x001C78F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206454, XrefRangeEnd = 206455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x001C9738 File Offset: 0x001C7938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206455, XrefRangeEnd = 206481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Il2CppSystem.Func<LandVehicle, bool> filter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection);
			ptr2 = &intPtr;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _exitOnSelectionLimit;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			initialSelection = ((intPtr3 == 0) ? null : new List<LandVehicle>(intPtr3));
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x001C97D0 File Offset: 0x001C79D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206501, RefRangeEnd = 206503, XrefRangeStart = 206481, XrefRangeEnd = 206501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x001C9804 File Offset: 0x001C7A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206503, XrefRangeEnd = 206553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x0002F0BF File Offset: 0x0002D2BF
		public VehicleSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06006421 RID: 25633 RVA: 0x001C9840 File Offset: 0x001C7A40
		// (set) Token: 0x06006422 RID: 25634 RVA: 0x0002F0C8 File Offset: 0x0002D2C8
		public unsafe float detectionRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06006423 RID: 25635 RVA: 0x001C9868 File Offset: 0x001C7A68
		// (set) Token: 0x06006424 RID: 25636 RVA: 0x0002F0E3 File Offset: 0x0002D2E3
		public unsafe LayerMask detectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x001C9890 File Offset: 0x001C7A90
		// (set) Token: 0x06006426 RID: 25638 RVA: 0x0002F0FE File Offset: 0x0002D2FE
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06006427 RID: 25639 RVA: 0x001C98B8 File Offset: 0x001C7AB8
		// (set) Token: 0x06006428 RID: 25640 RVA: 0x0002F119 File Offset: 0x0002D319
		public unsafe List<LandVehicle> selectedVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x001C98E8 File Offset: 0x001C7AE8
		// (set) Token: 0x0600642A RID: 25642 RVA: 0x0002F138 File Offset: 0x0002D338
		public unsafe Il2CppSystem.Action onClose
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x001C9918 File Offset: 0x001C7B18
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x0002F157 File Offset: 0x0002D357
		public unsafe int selectionLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x001C9940 File Offset: 0x001C7B40
		// (set) Token: 0x0600642E RID: 25646 RVA: 0x0002F172 File Offset: 0x0002D372
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001C9968 File Offset: 0x001C7B68
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x0002F18D File Offset: 0x0002D38D
		public unsafe LandVehicle hoveredVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x001C9998 File Offset: 0x001C7B98
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x0002F1AC File Offset: 0x0002D3AC
		public unsafe List<LandVehicle> outlinedVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x001C99C8 File Offset: 0x001C7BC8
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0002F1CB File Offset: 0x0002D3CB
		public unsafe Il2CppSystem.Func<LandVehicle, bool> vehicleFilter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LandVehicle, bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004442 RID: 17474
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004443 RID: 17475
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004444 RID: 17476
		private static readonly System.IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x04004445 RID: 17477
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedVehicles;

		// Token: 0x04004446 RID: 17478
		private static readonly System.IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04004447 RID: 17479
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x04004448 RID: 17480
		private static readonly System.IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x04004449 RID: 17481
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredVehicle;

		// Token: 0x0400444A RID: 17482
		private static readonly System.IntPtr NativeFieldInfoPtr_outlinedVehicles;

		// Token: 0x0400444B RID: 17483
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleFilter;

		// Token: 0x0400444C RID: 17484
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x0400444D RID: 17485
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x0400444E RID: 17486
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400444F RID: 17487
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004450 RID: 17488
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004451 RID: 17489
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0;

		// Token: 0x04004452 RID: 17490
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004453 RID: 17491
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0;

		// Token: 0x04004454 RID: 17492
		private static readonly System.IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x04004455 RID: 17493
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
