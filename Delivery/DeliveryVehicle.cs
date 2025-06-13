using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200049E RID: 1182
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x06006553 RID: 25939 RVA: 0x001CD590 File Offset: 0x001CB790
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryVehicle()
		{
			Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr);
			DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<Vehicle>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<ActiveDelivery>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "GUID");
			DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676240);
			DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676241);
			DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676242);
			DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676243);
			DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676244);
			DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676245);
			DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676246);
			DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100676247);
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x001CD69C File Offset: 0x001CB89C
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x001CD6DC File Offset: 0x001CB8DC
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x001CD720 File Offset: 0x001CB920
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x001CD760 File Offset: 0x001CB960
		public unsafe DeliveryInstance ActiveDelivery
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x001CD7A4 File Offset: 0x001CB9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207974, XrefRangeEnd = 207980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x001CD7D8 File Offset: 0x001CB9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208006, RefRangeEnd = 208007, XrefRangeStart = 207980, XrefRangeEnd = 208006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x001CD81C File Offset: 0x001CBA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208022, RefRangeEnd = 208024, XrefRangeStart = 208007, XrefRangeEnd = 208022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x001CD850 File Offset: 0x001CBA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208024, XrefRangeEnd = 208028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x0002FA9E File Offset: 0x0002DC9E
		public DeliveryVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x001CD88C File Offset: 0x001CBA8C
		// (set) Token: 0x0600655E RID: 25950 RVA: 0x0002FAA7 File Offset: 0x0002DCA7
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600655F RID: 25951 RVA: 0x001CD8BC File Offset: 0x001CBABC
		// (set) Token: 0x06006560 RID: 25952 RVA: 0x0002FAC6 File Offset: 0x0002DCC6
		public unsafe DeliveryInstance _ActiveDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x001CD8EC File Offset: 0x001CBAEC
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x0002FAE5 File Offset: 0x0002DCE5
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004529 RID: 17705
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x0400452A RID: 17706
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDelivery_k__BackingField;

		// Token: 0x0400452B RID: 17707
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400452C RID: 17708
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x0400452D RID: 17709
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x0400452E RID: 17710
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0;

		// Token: 0x0400452F RID: 17711
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0;

		// Token: 0x04004530 RID: 17712
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004531 RID: 17713
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0;

		// Token: 0x04004532 RID: 17714
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04004533 RID: 17715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
