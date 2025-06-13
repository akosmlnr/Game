using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000275 RID: 629
	public class DeliveriesData : SaveData
	{
		// Token: 0x0600300E RID: 12302 RVA: 0x0010D43C File Offset: 0x0010B63C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesData()
		{
			Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeliveriesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr);
			DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "ActiveDeliveries");
			DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "DeliveryVehicles");
			DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, 100668962);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0010D4A8 File Offset: 0x0010B6A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136247, XrefRangeEnd = 136250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesData(Il2CppReferenceArray<DeliveryInstance> deliveries, Il2CppReferenceArray<VehicleData> deliveryVehicles) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(deliveries);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryVehicles);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0001927B File Offset: 0x0001747B
		public DeliveriesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x0010D508 File Offset: 0x0010B708
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x00019284 File Offset: 0x00017484
		public unsafe Il2CppReferenceArray<DeliveryInstance> ActiveDeliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x0010D538 File Offset: 0x0010B738
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x000192A3 File Offset: 0x000174A3
		public unsafe Il2CppReferenceArray<VehicleData> DeliveryVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDeliveries;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryVehicles;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_0;
	}
}
