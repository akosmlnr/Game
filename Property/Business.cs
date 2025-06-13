using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200052D RID: 1325
	public class Business : Property
	{
		// Token: 0x0600742E RID: 29742 RVA: 0x001FE000 File Offset: 0x001FC200
		// Note: this type is marked as 'beforefieldinit'.
		static Business()
		{
			Il2CppClassPointerStore<Business>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Business");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business>.NativeClassPtr);
			Business.NativeFieldInfoPtr_Businesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "Businesses");
			Business.NativeFieldInfoPtr_UnownedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "UnownedBusinesses");
			Business.NativeFieldInfoPtr_OwnedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "OwnedBusinesses");
			Business.NativeFieldInfoPtr_LaunderCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderCapacity");
			Business.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderingOperations");
			Business.NativeFieldInfoPtr_onOperationStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationStarted");
			Business.NativeFieldInfoPtr_onOperationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationFinished");
			Business.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "loader");
			Business.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677956);
			Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677957);
			Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677958);
			Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677959);
			Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677960);
			Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677961);
			Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677962);
			Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677963);
			Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677964);
			Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677965);
			Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677966);
			Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677967);
			Business.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677968);
			Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677969);
			Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677970);
			Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677971);
			Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677972);
			Business.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677973);
			Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677975);
			Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677976);
			Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677977);
			Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677978);
			Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677979);
			Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677980);
			Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677981);
			Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677982);
			Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677983);
			Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677984);
			Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677985);
			Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677986);
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x001FE350 File Offset: 0x001FC550
		public unsafe float currentLaunderTotal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 227780, RefRangeEnd = 227791, XrefRangeStart = 227762, XrefRangeEnd = 227780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x001FE38C File Offset: 0x001FC58C
		public unsafe float appliedLaunderLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227792, RefRangeEnd = 227793, XrefRangeStart = 227791, XrefRangeEnd = 227792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x001FE3C8 File Offset: 0x001FC5C8
		public new unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x001FE408 File Offset: 0x001FC608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227793, XrefRangeEnd = 227794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x001FE444 File Offset: 0x001FC644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227794, XrefRangeEnd = 227829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x001FE480 File Offset: 0x001FC680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227829, XrefRangeEnd = 227844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x001FE4BC File Offset: 0x001FC6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227844, XrefRangeEnd = 227850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x001FE50C File Offset: 0x001FC70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227850, XrefRangeEnd = 227859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x001FE55C File Offset: 0x001FC75C
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x001FE598 File Offset: 0x001FC798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227859, XrefRangeEnd = 227871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinsPass(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mins;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x001FE5E4 File Offset: 0x001FC7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227871, XrefRangeEnd = 227895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsPassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref minsPassed;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x001FE624 File Offset: 0x001FC824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227895, XrefRangeEnd = 227941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x001FE668 File Offset: 0x001FC868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227941, XrefRangeEnd = 227986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(PropertyData propertyData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x001FE6B8 File Offset: 0x001FC8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227986, XrefRangeEnd = 228004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x001FE6F4 File Offset: 0x001FC8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228016, RefRangeEnd = 228017, XrefRangeStart = 228004, XrefRangeEnd = 228016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x001FE740 File Offset: 0x001FC940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228052, RefRangeEnd = 228055, XrefRangeStart = 228017, XrefRangeEnd = 228052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x001FE7A0 File Offset: 0x001FC9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228106, RefRangeEnd = 228107, XrefRangeStart = 228055, XrefRangeEnd = 228106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteOperation(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x001FE7E4 File Offset: 0x001FC9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228107, XrefRangeEnd = 228123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Business() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x001FE820 File Offset: 0x001FCA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228123, XrefRangeEnd = 228144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x001FE85C File Offset: 0x001FCA5C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x001FE898 File Offset: 0x001FCA98
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x001FE8D4 File Offset: 0x001FCAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228016, RefRangeEnd = 228017, XrefRangeStart = 228016, XrefRangeEnd = 228017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x001FE920 File Offset: 0x001FCB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228144, XrefRangeEnd = 228145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x001FE96C File Offset: 0x001FCB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228145, XrefRangeEnd = 228150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x001FE9D0 File Offset: 0x001FCBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228150, XrefRangeEnd = 228162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x001FEA30 File Offset: 0x001FCC30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228199, RefRangeEnd = 228201, XrefRangeStart = 228162, XrefRangeEnd = 228199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x001FEA90 File Offset: 0x001FCC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228201, XrefRangeEnd = 228207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x001FEAE0 File Offset: 0x001FCCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228207, XrefRangeEnd = 228219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x001FEB40 File Offset: 0x001FCD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228219, XrefRangeEnd = 228224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x001FEB90 File Offset: 0x001FCD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228244, RefRangeEnd = 228245, XrefRangeStart = 228224, XrefRangeEnd = 228244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x000370F5 File Offset: 0x000352F5
		public Business(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x001FEBCC File Offset: 0x001FCDCC
		// (set) Token: 0x0600744F RID: 29775 RVA: 0x000370FE File Offset: 0x000352FE
		public unsafe static List<Business> Businesses
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_Businesses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_Businesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06007450 RID: 29776 RVA: 0x001FEBF4 File Offset: 0x001FCDF4
		// (set) Token: 0x06007451 RID: 29777 RVA: 0x00037110 File Offset: 0x00035310
		public unsafe static List<Business> UnownedBusinesses
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_UnownedBusinesses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_UnownedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x001FEC1C File Offset: 0x001FCE1C
		// (set) Token: 0x06007453 RID: 29779 RVA: 0x00037122 File Offset: 0x00035322
		public unsafe static List<Business> OwnedBusinesses
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_OwnedBusinesses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_OwnedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x001FEC44 File Offset: 0x001FCE44
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x00037134 File Offset: 0x00035334
		public unsafe float LaunderCapacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity)) = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x001FEC6C File Offset: 0x001FCE6C
		// (set) Token: 0x06007457 RID: 29783 RVA: 0x0003714F File Offset: 0x0003534F
		public unsafe List<LaunderingOperation> LaunderingOperations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x001FEC9C File Offset: 0x001FCE9C
		// (set) Token: 0x06007459 RID: 29785 RVA: 0x0003716E File Offset: 0x0003536E
		public unsafe static Il2CppSystem.Action<LaunderingOperation> onOperationStarted
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationStarted, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x001FECC4 File Offset: 0x001FCEC4
		// (set) Token: 0x0600745B RID: 29787 RVA: 0x00037180 File Offset: 0x00035380
		public unsafe static Il2CppSystem.Action<LaunderingOperation> onOperationFinished
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationFinished, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600745C RID: 29788 RVA: 0x001FECEC File Offset: 0x001FCEEC
		// (set) Token: 0x0600745D RID: 29789 RVA: 0x00037192 File Offset: 0x00035392
		public new unsafe BusinessLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600745E RID: 29790 RVA: 0x001FED1C File Offset: 0x001FCF1C
		// (set) Token: 0x0600745F RID: 29791 RVA: 0x000371B1 File Offset: 0x000353B1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06007460 RID: 29792 RVA: 0x001FED44 File Offset: 0x001FCF44
		// (set) Token: 0x06007461 RID: 29793 RVA: 0x000371CC File Offset: 0x000353CC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F47 RID: 20295
		private static readonly System.IntPtr NativeFieldInfoPtr_Businesses;

		// Token: 0x04004F48 RID: 20296
		private static readonly System.IntPtr NativeFieldInfoPtr_UnownedBusinesses;

		// Token: 0x04004F49 RID: 20297
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnedBusinesses;

		// Token: 0x04004F4A RID: 20298
		private static readonly System.IntPtr NativeFieldInfoPtr_LaunderCapacity;

		// Token: 0x04004F4B RID: 20299
		private static readonly System.IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04004F4C RID: 20300
		private static readonly System.IntPtr NativeFieldInfoPtr_onOperationStarted;

		// Token: 0x04004F4D RID: 20301
		private static readonly System.IntPtr NativeFieldInfoPtr_onOperationFinished;

		// Token: 0x04004F4E RID: 20302
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004F4F RID: 20303
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F50 RID: 20304
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F51 RID: 20305
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0;

		// Token: 0x04004F52 RID: 20306
		private static readonly System.IntPtr NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0;

		// Token: 0x04004F53 RID: 20307
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004F54 RID: 20308
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004F55 RID: 20309
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04004F56 RID: 20310
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04004F57 RID: 20311
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0;

		// Token: 0x04004F58 RID: 20312
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004F59 RID: 20313
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04004F5A RID: 20314
		private static readonly System.IntPtr NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly System.IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x04004F5C RID: 20316
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04004F5D RID: 20317
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0;

		// Token: 0x04004F5E RID: 20318
		private static readonly System.IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1;

		// Token: 0x04004F5F RID: 20319
		private static readonly System.IntPtr NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0;

		// Token: 0x04004F60 RID: 20320
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004F61 RID: 20321
		private static readonly System.IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0;

		// Token: 0x04004F62 RID: 20322
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F63 RID: 20323
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F64 RID: 20324
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F65 RID: 20325
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F66 RID: 20326
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0;

		// Token: 0x04004F67 RID: 20327
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0;

		// Token: 0x04004F68 RID: 20328
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F69 RID: 20329
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004F6A RID: 20330
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004F6B RID: 20331
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F6C RID: 20332
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004F6D RID: 20333
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F6E RID: 20334
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000ACF RID: 2767
		[ObfuscatedName("ScheduleOne.Property.Business+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D729 RID: 55081 RVA: 0x00339F0C File Offset: 0x0033810C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Business.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Business>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business.__c>.NativeClassPtr);
				Business.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9");
				Business.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9__8_0");
				Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677988);
				Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677989);
			}

			// Token: 0x0600D72A RID: 55082 RVA: 0x00339F88 File Offset: 0x00338188
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D72B RID: 55083 RVA: 0x00339FC4 File Offset: 0x003381C4
			[CallerCount(0)]
			public unsafe float _get_currentLaunderTotal_b__8_0(LaunderingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D72C RID: 55084 RVA: 0x00068777 File Offset: 0x00066977
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700427C RID: 17020
			// (get) Token: 0x0600D72D RID: 55085 RVA: 0x0033A014 File Offset: 0x00338214
			// (set) Token: 0x0600D72E RID: 55086 RVA: 0x00068780 File Offset: 0x00066980
			public unsafe static Business.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427D RID: 17021
			// (get) Token: 0x0600D72F RID: 55087 RVA: 0x0033A03C File Offset: 0x0033823C
			// (set) Token: 0x0600D730 RID: 55088 RVA: 0x00068792 File Offset: 0x00066992
			public unsafe static Il2CppSystem.Func<LaunderingOperation, float> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LaunderingOperation, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009131 RID: 37169
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009132 RID: 37170
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009133 RID: 37171
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009134 RID: 37172
			private static readonly System.IntPtr NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0;
		}
	}
}
