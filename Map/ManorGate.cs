using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A7 RID: 1959
	public class ManorGate : Gate
	{
		// Token: 0x0600B973 RID: 47475 RVA: 0x002E4424 File Offset: 0x002E2624
		// Note: this type is marked as 'beforefieldinit'.
		static ManorGate()
		{
			Il2CppClassPointerStore<ManorGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ManorGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManorGate>.NativeClassPtr);
			ManorGate.NativeFieldInfoPtr_IntercomInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomInt");
			ManorGate.NativeFieldInfoPtr_IntercomLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomLight");
			ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_intercomActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "intercomActive");
			ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686243);
			ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686244);
			ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686245);
			ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686246);
			ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686247);
			ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686248);
			ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686249);
			ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100686250);
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x002E4580 File Offset: 0x002E2780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316290, XrefRangeEnd = 316298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x002E45BC File Offset: 0x002E27BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316298, XrefRangeEnd = 316302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x002E45F0 File Offset: 0x002E27F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316302, XrefRangeEnd = 316304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntercomBuzzed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x002E4624 File Offset: 0x002E2824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316308, RefRangeEnd = 316309, XrefRangeStart = 316304, XrefRangeEnd = 316308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnterable(bool enterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enterable;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x002E4664 File Offset: 0x002E2864
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316311, RefRangeEnd = 316314, XrefRangeStart = 316309, XrefRangeEnd = 316311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x002E4698 File Offset: 0x002E2898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316314, XrefRangeEnd = 316316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntercomActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x002E46D8 File Offset: 0x002E28D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316316, XrefRangeEnd = 316318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x002E470C File Offset: 0x002E290C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManorGate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManorGate>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x0005AA5D File Offset: 0x00058C5D
		public ManorGate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x002E4748 File Offset: 0x002E2948
		// (set) Token: 0x0600B97E RID: 47486 RVA: 0x0005AA66 File Offset: 0x00058C66
		public unsafe InteractableObject IntercomInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600B97F RID: 47487 RVA: 0x002E4778 File Offset: 0x002E2978
		// (set) Token: 0x0600B980 RID: 47488 RVA: 0x0005AA85 File Offset: 0x00058C85
		public unsafe Light IntercomLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x002E47A8 File Offset: 0x002E29A8
		// (set) Token: 0x0600B982 RID: 47490 RVA: 0x0005AAA4 File Offset: 0x00058CA4
		public unsafe VehicleDetector ExteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600B983 RID: 47491 RVA: 0x002E47D8 File Offset: 0x002E29D8
		// (set) Token: 0x0600B984 RID: 47492 RVA: 0x0005AAC3 File Offset: 0x00058CC3
		public unsafe PlayerDetector ExteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600B985 RID: 47493 RVA: 0x002E4808 File Offset: 0x002E2A08
		// (set) Token: 0x0600B986 RID: 47494 RVA: 0x0005AAE2 File Offset: 0x00058CE2
		public unsafe VehicleDetector InteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600B987 RID: 47495 RVA: 0x002E4838 File Offset: 0x002E2A38
		// (set) Token: 0x0600B988 RID: 47496 RVA: 0x0005AB01 File Offset: 0x00058D01
		public unsafe PlayerDetector InteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x002E4868 File Offset: 0x002E2A68
		// (set) Token: 0x0600B98A RID: 47498 RVA: 0x0005AB20 File Offset: 0x00058D20
		public unsafe bool intercomActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive)) = value;
			}
		}

		// Token: 0x04007D1C RID: 32028
		private static readonly IntPtr NativeFieldInfoPtr_IntercomInt;

		// Token: 0x04007D1D RID: 32029
		private static readonly IntPtr NativeFieldInfoPtr_IntercomLight;

		// Token: 0x04007D1E RID: 32030
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorVehicleDetector;

		// Token: 0x04007D1F RID: 32031
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorPlayerDetector;

		// Token: 0x04007D20 RID: 32032
		private static readonly IntPtr NativeFieldInfoPtr_InteriorVehicleDetector;

		// Token: 0x04007D21 RID: 32033
		private static readonly IntPtr NativeFieldInfoPtr_InteriorPlayerDetector;

		// Token: 0x04007D22 RID: 32034
		private static readonly IntPtr NativeFieldInfoPtr_intercomActive;

		// Token: 0x04007D23 RID: 32035
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007D24 RID: 32036
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDetection_Private_Void_0;

		// Token: 0x04007D25 RID: 32037
		private static readonly IntPtr NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0;

		// Token: 0x04007D26 RID: 32038
		private static readonly IntPtr NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0;

		// Token: 0x04007D27 RID: 32039
		private static readonly IntPtr NativeMethodInfoPtr_ActivateIntercom_Public_Void_0;

		// Token: 0x04007D28 RID: 32040
		private static readonly IntPtr NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0;

		// Token: 0x04007D29 RID: 32041
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIntercom_Private_Void_0;

		// Token: 0x04007D2A RID: 32042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
