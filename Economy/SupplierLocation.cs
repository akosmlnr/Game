using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200043C RID: 1084
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x06005E23 RID: 24099 RVA: 0x001B5834 File Offset: 0x001B3A34
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocation()
		{
			Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr);
			SupplierLocation.NativeFieldInfoPtr_AllLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "AllLocations");
			SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "<ActiveSupplier>k__BackingField");
			SupplierLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationName");
			SupplierLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationDescription");
			SupplierLocation.NativeFieldInfoPtr_GenericContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "GenericContainer");
			SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "SupplierStandPoint");
			SupplierLocation.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "DeliveryBays");
			SupplierLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "PoI");
			SupplierLocation.NativeFieldInfoPtr_configs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "configs");
			SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675403);
			SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675404);
			SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675405);
			SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675406);
			SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675407);
			SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675408);
			SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675409);
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x001B59A4 File Offset: 0x001B3BA4
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199080, XrefRangeEnd = 199084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06005E25 RID: 24101 RVA: 0x001B59E0 File Offset: 0x001B3BE0
		// (set) Token: 0x06005E26 RID: 24102 RVA: 0x001B5A20 File Offset: 0x001B3C20
		public unsafe Supplier ActiveSupplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x001B5A64 File Offset: 0x001B3C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199084, XrefRangeEnd = 199108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x001B5A98 File Offset: 0x001B3C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199108, XrefRangeEnd = 199116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x001B5ACC File Offset: 0x001B3CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199151, RefRangeEnd = 199154, XrefRangeStart = 199116, XrefRangeEnd = 199151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x001B5B10 File Offset: 0x001B3D10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0002C238 File Offset: 0x0002A438
		public SupplierLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x001B5B4C File Offset: 0x001B3D4C
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x0002C241 File Offset: 0x0002A441
		public unsafe static List<SupplierLocation> AllLocations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SupplierLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x001B5B74 File Offset: 0x001B3D74
		// (set) Token: 0x06005E2F RID: 24111 RVA: 0x0002C253 File Offset: 0x0002A453
		public unsafe Supplier _ActiveSupplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x001B5BA4 File Offset: 0x001B3DA4
		// (set) Token: 0x06005E31 RID: 24113 RVA: 0x0002C272 File Offset: 0x0002A472
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x001B5BCC File Offset: 0x001B3DCC
		// (set) Token: 0x06005E33 RID: 24115 RVA: 0x0002C291 File Offset: 0x0002A491
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x001B5BF4 File Offset: 0x001B3DF4
		// (set) Token: 0x06005E35 RID: 24117 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		public unsafe Transform GenericContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x001B5C24 File Offset: 0x001B3E24
		// (set) Token: 0x06005E37 RID: 24119 RVA: 0x0002C2CF File Offset: 0x0002A4CF
		public unsafe Transform SupplierStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x001B5C54 File Offset: 0x001B3E54
		// (set) Token: 0x06005E39 RID: 24121 RVA: 0x0002C2EE File Offset: 0x0002A4EE
		public unsafe Il2CppReferenceArray<WorldStorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x001B5C84 File Offset: 0x001B3E84
		// (set) Token: 0x06005E3B RID: 24123 RVA: 0x0002C30D File Offset: 0x0002A50D
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06005E3C RID: 24124 RVA: 0x001B5CB4 File Offset: 0x001B3EB4
		// (set) Token: 0x06005E3D RID: 24125 RVA: 0x0002C32C File Offset: 0x0002A52C
		public unsafe Il2CppReferenceArray<SupplierLocationConfiguration> configs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SupplierLocationConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400406A RID: 16490
		private static readonly IntPtr NativeFieldInfoPtr_AllLocations;

		// Token: 0x0400406B RID: 16491
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSupplier_k__BackingField;

		// Token: 0x0400406C RID: 16492
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x0400406D RID: 16493
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x0400406E RID: 16494
		private static readonly IntPtr NativeFieldInfoPtr_GenericContainer;

		// Token: 0x0400406F RID: 16495
		private static readonly IntPtr NativeFieldInfoPtr_SupplierStandPoint;

		// Token: 0x04004070 RID: 16496
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04004071 RID: 16497
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04004072 RID: 16498
		private static readonly IntPtr NativeFieldInfoPtr_configs;

		// Token: 0x04004073 RID: 16499
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04004074 RID: 16500
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0;

		// Token: 0x04004075 RID: 16501
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0;

		// Token: 0x04004076 RID: 16502
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004077 RID: 16503
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004078 RID: 16504
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0;

		// Token: 0x04004079 RID: 16505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
