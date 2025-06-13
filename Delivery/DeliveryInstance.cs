using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200049C RID: 1180
	[System.Serializable]
	public class DeliveryInstance : Il2CppSystem.Object
	{
		// Token: 0x060064F5 RID: 25845 RVA: 0x001CBE5C File Offset: 0x001CA05C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryInstance()
		{
			Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr);
			DeliveryInstance.NativeFieldInfoPtr_DeliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DeliveryID");
			DeliveryInstance.NativeFieldInfoPtr_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "StoreName");
			DeliveryInstance.NativeFieldInfoPtr_DestinationCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DestinationCode");
			DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "LoadingDockIndex");
			DeliveryInstance.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Items");
			DeliveryInstance.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Status");
			DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "TimeUntilArrival");
			DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "<ActiveVehicle>k__BackingField");
			DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676182);
			DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676183);
			DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676184);
			DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676185);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676186);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676187);
			DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676188);
			DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676189);
			DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676190);
			DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100676191);
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x001CC008 File Offset: 0x001CA208
		// (set) Token: 0x060064F7 RID: 25847 RVA: 0x001CC048 File Offset: 0x001CA248
		public unsafe DeliveryVehicle ActiveVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060064F8 RID: 25848 RVA: 0x001CC08C File Offset: 0x001CA28C
		public unsafe Property Destination
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 207468, RefRangeEnd = 207475, XrefRangeStart = 207462, XrefRangeEnd = 207468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x001CC0CC File Offset: 0x001CA2CC
		public unsafe LoadingDock LoadingDock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207475, XrefRangeEnd = 207476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingDock>(intPtr2) : null;
			}
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x001CC10C File Offset: 0x001CA30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207481, RefRangeEnd = 207482, XrefRangeStart = 207476, XrefRangeEnd = 207481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, Il2CppReferenceArray<StringIntPair> items, EDeliveryStatus status, int timeUntilArrival) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationCode);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadingDockIndex;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref status;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref timeUntilArrival;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x001CC1B8 File Offset: 0x001CA3B8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x001CC1F4 File Offset: 0x001CA3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207482, RefRangeEnd = 207483, XrefRangeStart = 207482, XrefRangeEnd = 207482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTimeStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x001CC230 File Offset: 0x001CA430
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207525, RefRangeEnd = 207528, XrefRangeStart = 207483, XrefRangeEnd = 207525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref status;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x001CC270 File Offset: 0x001CA470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207537, RefRangeEnd = 207538, XrefRangeStart = 207528, XrefRangeEnd = 207537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemsToDeliveryVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x001CC2A4 File Offset: 0x001CA4A4
		[CallerCount(0)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x0002F838 File Offset: 0x0002DA38
		public DeliveryInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x001CC2D8 File Offset: 0x001CA4D8
		// (set) Token: 0x06006502 RID: 25858 RVA: 0x0002F841 File Offset: 0x0002DA41
		public unsafe string DeliveryID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06006503 RID: 25859 RVA: 0x001CC300 File Offset: 0x001CA500
		// (set) Token: 0x06006504 RID: 25860 RVA: 0x0002F860 File Offset: 0x0002DA60
		public unsafe string StoreName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x001CC328 File Offset: 0x001CA528
		// (set) Token: 0x06006506 RID: 25862 RVA: 0x0002F87F File Offset: 0x0002DA7F
		public unsafe string DestinationCode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x001CC350 File Offset: 0x001CA550
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x0002F89E File Offset: 0x0002DA9E
		public unsafe int LoadingDockIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex)) = value;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x001CC378 File Offset: 0x001CA578
		// (set) Token: 0x0600650A RID: 25866 RVA: 0x0002F8B9 File Offset: 0x0002DAB9
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x001CC3A8 File Offset: 0x001CA5A8
		// (set) Token: 0x0600650C RID: 25868 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
		public unsafe EDeliveryStatus Status
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600650D RID: 25869 RVA: 0x001CC3D0 File Offset: 0x001CA5D0
		// (set) Token: 0x0600650E RID: 25870 RVA: 0x0002F8F3 File Offset: 0x0002DAF3
		public unsafe int TimeUntilArrival
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival)) = value;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600650F RID: 25871 RVA: 0x001CC3F8 File Offset: 0x001CA5F8
		// (set) Token: 0x06006510 RID: 25872 RVA: 0x0002F90E File Offset: 0x0002DB0E
		public unsafe DeliveryVehicle _ActiveVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x001CC428 File Offset: 0x001CA628
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x0002F92D File Offset: 0x0002DB2D
		public unsafe UnityEvent onDeliveryCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044E3 RID: 17635
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryID;

		// Token: 0x040044E4 RID: 17636
		private static readonly System.IntPtr NativeFieldInfoPtr_StoreName;

		// Token: 0x040044E5 RID: 17637
		private static readonly System.IntPtr NativeFieldInfoPtr_DestinationCode;

		// Token: 0x040044E6 RID: 17638
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadingDockIndex;

		// Token: 0x040044E7 RID: 17639
		private static readonly System.IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x040044E8 RID: 17640
		private static readonly System.IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x040044E9 RID: 17641
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeUntilArrival;

		// Token: 0x040044EA RID: 17642
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveVehicle_k__BackingField;

		// Token: 0x040044EB RID: 17643
		private static readonly System.IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x040044EC RID: 17644
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0;

		// Token: 0x040044ED RID: 17645
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0;

		// Token: 0x040044EE RID: 17646
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Destination_Public_get_Property_0;

		// Token: 0x040044EF RID: 17647
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0;

		// Token: 0x040044F0 RID: 17648
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0;

		// Token: 0x040044F1 RID: 17649
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044F2 RID: 17650
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0;

		// Token: 0x040044F3 RID: 17651
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0;

		// Token: 0x040044F4 RID: 17652
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0;

		// Token: 0x040044F5 RID: 17653
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Public_Void_0;
	}
}
