using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004FF RID: 1279
	public class Forklift : LandVehicle
	{
		// Token: 0x06006ECB RID: 28363 RVA: 0x001ED40C File Offset: 0x001EB60C
		// Note: this type is marked as 'beforefieldinit'.
		static Forklift()
		{
			Il2CppClassPointerStore<Forklift>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Forklift");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forklift>.NativeClassPtr);
			Forklift.NativeFieldInfoPtr_steeringWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheel");
			Forklift.NativeFieldInfoPtr_forkRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "forkRb");
			Forklift.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "joint");
			Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheelAngleMultiplier");
			Forklift.NativeFieldInfoPtr_lift_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MinY");
			Forklift.NativeFieldInfoPtr_lift_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MaxY");
			Forklift.NativeFieldInfoPtr_liftMoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "liftMoveRate");
			Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lastFrameTargetForkHeight");
			Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677395);
			Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677396);
			Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677397);
			Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677398);
			Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677399);
			Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677400);
			Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677401);
			Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677402);
			Forklift.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677403);
			Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677404);
			Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677405);
			Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677406);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677407);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677408);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677409);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677410);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677411);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677412);
			Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677413);
			Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677414);
			Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677415);
			Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677416);
			Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677417);
			Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677418);
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x001ED734 File Offset: 0x001EB934
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x001ED770 File Offset: 0x001EB970
		public unsafe float targetForkHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 221643, RefRangeEnd = 221645, XrefRangeStart = 221610, XrefRangeEnd = 221643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x001ED7B0 File Offset: 0x001EB9B0
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x001ED7EC File Offset: 0x001EB9EC
		public unsafe float actualForkHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221678, RefRangeEnd = 221679, XrefRangeStart = 221645, XrefRangeEnd = 221678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x001ED82C File Offset: 0x001EBA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221679, XrefRangeEnd = 221691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x001ED868 File Offset: 0x001EBA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221691, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x001ED8A4 File Offset: 0x001EBAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221698, XrefRangeEnd = 221714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x001ED8E0 File Offset: 0x001EBAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221714, XrefRangeEnd = 221728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x001ED91C File Offset: 0x001EBB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221728, XrefRangeEnd = 221729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Forklift() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Forklift>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x001ED958 File Offset: 0x001EBB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221729, XrefRangeEnd = 221766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x001ED994 File Offset: 0x001EBB94
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x001ED9D0 File Offset: 0x001EBBD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x001EDA0C File Offset: 0x001EBC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221766, XrefRangeEnd = 221778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x001EDA4C File Offset: 0x001EBC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221785, RefRangeEnd = 221787, XrefRangeStart = 221778, XrefRangeEnd = 221785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x001EDA8C File Offset: 0x001EBC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221787, XrefRangeEnd = 221792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x001EDAF0 File Offset: 0x001EBCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221792, XrefRangeEnd = 221804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x001EDB30 File Offset: 0x001EBD30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221811, RefRangeEnd = 221813, XrefRangeStart = 221804, XrefRangeEnd = 221811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x001EDB70 File Offset: 0x001EBD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221813, XrefRangeEnd = 221818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x001EDBD4 File Offset: 0x001EBDD4
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x001EDC10 File Offset: 0x001EBE10
		public unsafe float SyncAccessor_<targetForkHeight>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221826, RefRangeEnd = 221827, XrefRangeStart = 221818, XrefRangeEnd = 221826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x001EDC5C File Offset: 0x001EBE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221827, XrefRangeEnd = 221831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Vehicles_Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x001EDCD0 File Offset: 0x001EBED0
		// (set) Token: 0x06006EE2 RID: 28386 RVA: 0x001EDD0C File Offset: 0x001EBF0C
		public unsafe float SyncAccessor_<actualForkHeight>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221831, XrefRangeEnd = 221839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x001EDD58 File Offset: 0x001EBF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221839, XrefRangeEnd = 221850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00034359 File Offset: 0x00032559
		public Forklift(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006EE5 RID: 28389 RVA: 0x001EDD94 File Offset: 0x001EBF94
		// (set) Token: 0x06006EE6 RID: 28390 RVA: 0x00034362 File Offset: 0x00032562
		public unsafe Transform steeringWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006EE7 RID: 28391 RVA: 0x001EDDC4 File Offset: 0x001EBFC4
		// (set) Token: 0x06006EE8 RID: 28392 RVA: 0x00034381 File Offset: 0x00032581
		public unsafe Rigidbody forkRb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06006EE9 RID: 28393 RVA: 0x001EDDF4 File Offset: 0x001EBFF4
		// (set) Token: 0x06006EEA RID: 28394 RVA: 0x000343A0 File Offset: 0x000325A0
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06006EEB RID: 28395 RVA: 0x001EDE24 File Offset: 0x001EC024
		// (set) Token: 0x06006EEC RID: 28396 RVA: 0x000343BF File Offset: 0x000325BF
		public unsafe float steeringWheelAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier)) = value;
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x001EDE4C File Offset: 0x001EC04C
		// (set) Token: 0x06006EEE RID: 28398 RVA: 0x000343DA File Offset: 0x000325DA
		public unsafe float lift_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY)) = value;
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006EEF RID: 28399 RVA: 0x001EDE74 File Offset: 0x001EC074
		// (set) Token: 0x06006EF0 RID: 28400 RVA: 0x000343F5 File Offset: 0x000325F5
		public unsafe float lift_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY)) = value;
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x001EDE9C File Offset: 0x001EC09C
		// (set) Token: 0x06006EF2 RID: 28402 RVA: 0x00034410 File Offset: 0x00032610
		public unsafe float liftMoveRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate)) = value;
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x001EDEC4 File Offset: 0x001EC0C4
		// (set) Token: 0x06006EF4 RID: 28404 RVA: 0x0003442B File Offset: 0x0003262B
		public unsafe float _targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x001EDEEC File Offset: 0x001EC0EC
		// (set) Token: 0x06006EF6 RID: 28406 RVA: 0x00034446 File Offset: 0x00032646
		public unsafe float lastFrameTargetForkHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight)) = value;
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06006EF7 RID: 28407 RVA: 0x001EDF14 File Offset: 0x001EC114
		// (set) Token: 0x06006EF8 RID: 28408 RVA: 0x00034461 File Offset: 0x00032661
		public unsafe float _actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x001EDF3C File Offset: 0x001EC13C
		// (set) Token: 0x06006EFA RID: 28410 RVA: 0x0003447C File Offset: 0x0003267C
		public unsafe SyncVar<float> syncVar____targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06006EFB RID: 28411 RVA: 0x001EDF6C File Offset: 0x001EC16C
		// (set) Token: 0x06006EFC RID: 28412 RVA: 0x0003449B File Offset: 0x0003269B
		public unsafe SyncVar<float> syncVar____actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x001EDF9C File Offset: 0x001EC19C
		// (set) Token: 0x06006EFE RID: 28414 RVA: 0x000344BA File Offset: 0x000326BA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001EDFC4 File Offset: 0x001EC1C4
		// (set) Token: 0x06006F00 RID: 28416 RVA: 0x000344D5 File Offset: 0x000326D5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004BBD RID: 19389
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheel;

		// Token: 0x04004BBE RID: 19390
		private static readonly IntPtr NativeFieldInfoPtr_forkRb;

		// Token: 0x04004BBF RID: 19391
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04004BC0 RID: 19392
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheelAngleMultiplier;

		// Token: 0x04004BC1 RID: 19393
		private static readonly IntPtr NativeFieldInfoPtr_lift_MinY;

		// Token: 0x04004BC2 RID: 19394
		private static readonly IntPtr NativeFieldInfoPtr_lift_MaxY;

		// Token: 0x04004BC3 RID: 19395
		private static readonly IntPtr NativeFieldInfoPtr_liftMoveRate;

		// Token: 0x04004BC4 RID: 19396
		private static readonly IntPtr NativeFieldInfoPtr__targetForkHeight_k__BackingField;

		// Token: 0x04004BC5 RID: 19397
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameTargetForkHeight;

		// Token: 0x04004BC6 RID: 19398
		private static readonly IntPtr NativeFieldInfoPtr__actualForkHeight_k__BackingField;

		// Token: 0x04004BC7 RID: 19399
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField;

		// Token: 0x04004BC8 RID: 19400
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField;

		// Token: 0x04004BC9 RID: 19401
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004BCA RID: 19402
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004BCB RID: 19403
		private static readonly IntPtr NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0;

		// Token: 0x04004BCC RID: 19404
		private static readonly IntPtr NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004BCD RID: 19405
		private static readonly IntPtr NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0;

		// Token: 0x04004BCE RID: 19406
		private static readonly IntPtr NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004BCF RID: 19407
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004BD0 RID: 19408
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x04004BD1 RID: 19409
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x04004BD2 RID: 19410
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD3 RID: 19411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BD4 RID: 19412
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004BD5 RID: 19413
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004BD6 RID: 19414
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004BD7 RID: 19415
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004BD8 RID: 19416
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004BD9 RID: 19417
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004BDA RID: 19418
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004BDB RID: 19419
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004BDC RID: 19420
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004BDD RID: 19421
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004BDE RID: 19422
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004BDF RID: 19423
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004BE0 RID: 19424
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004BE1 RID: 19425
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004BE2 RID: 19426
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
