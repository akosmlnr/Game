using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Phone.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200049D RID: 1181
	public class DeliveryManager : NetworkSingleton<DeliveryManager>
	{
		// Token: 0x06006513 RID: 25875 RVA: 0x001CC458 File Offset: 0x001CA658
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryManager()
		{
			Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr);
			DeliveryManager.NativeFieldInfoPtr_Deliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "Deliveries");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCreated");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "loader");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr_writtenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "writtenVehicles");
			DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "minsSinceVehicleEmpty");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676192);
			DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676193);
			DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676194);
			DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676195);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676196);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676197);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676198);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676199);
			DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676200);
			DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676201);
			DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676202);
			DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676203);
			DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676204);
			DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676205);
			DeliveryManager.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676206);
			DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676207);
			DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676208);
			DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676209);
			DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676210);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676211);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676212);
			DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676213);
			DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676214);
			DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676215);
			DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676216);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676217);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676218);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676219);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676220);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676221);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676222);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676223);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676224);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676225);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676226);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676227);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676228);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676229);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676230);
			DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100676231);
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06006514 RID: 25876 RVA: 0x001CC884 File Offset: 0x001CAA84
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207542, XrefRangeEnd = 207544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06006515 RID: 25877 RVA: 0x001CC8BC File Offset: 0x001CAABC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207544, XrefRangeEnd = 207546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06006516 RID: 25878 RVA: 0x001CC8F4 File Offset: 0x001CAAF4
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x001CC934 File Offset: 0x001CAB34
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x001CC970 File Offset: 0x001CAB70
		// (set) Token: 0x06006519 RID: 25881 RVA: 0x001CC9B0 File Offset: 0x001CABB0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x001CC9F4 File Offset: 0x001CABF4
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x001CCA34 File Offset: 0x001CAC34
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97050, RefRangeEnd = 97051, XrefRangeStart = 97050, XrefRangeEnd = 97051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600651C RID: 25884 RVA: 0x001CCA78 File Offset: 0x001CAC78
		// (set) Token: 0x0600651D RID: 25885 RVA: 0x001CCAB4 File Offset: 0x001CACB4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x001CCAF4 File Offset: 0x001CACF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207546, XrefRangeEnd = 207549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x001CCB30 File Offset: 0x001CAD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207549, XrefRangeEnd = 207570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x001CCB6C File Offset: 0x001CAD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207570, XrefRangeEnd = 207576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x001CCBA8 File Offset: 0x001CADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207576, XrefRangeEnd = 207611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x001CCBF8 File Offset: 0x001CADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207611, XrefRangeEnd = 207657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x001CCC2C File Offset: 0x001CAE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207661, RefRangeEnd = 207662, XrefRangeStart = 207657, XrefRangeEnd = 207661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadingDockIndex;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x001CCC88 File Offset: 0x001CAE88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207672, RefRangeEnd = 207674, XrefRangeStart = 207662, XrefRangeEnd = 207672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDelivery(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x001CCCCC File Offset: 0x001CAECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207705, RefRangeEnd = 207707, XrefRangeStart = 207674, XrefRangeEnd = 207705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x001CCD20 File Offset: 0x001CAF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207707, XrefRangeEnd = 207709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref status;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x001CCD70 File Offset: 0x001CAF70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207724, RefRangeEnd = 207728, XrefRangeStart = 207709, XrefRangeEnd = 207724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(string deliveryID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x001CCDC0 File Offset: 0x001CAFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207728, XrefRangeEnd = 207743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(Property destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x001CCE10 File Offset: 0x001CB010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207758, RefRangeEnd = 207760, XrefRangeStart = 207743, XrefRangeEnd = 207758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x001CCE60 File Offset: 0x001CB060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207760, XrefRangeEnd = 207779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface GetShopInterface(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x001CCEB0 File Offset: 0x001CB0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207779, XrefRangeEnd = 207816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x001CCEF4 File Offset: 0x001CB0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207816, XrefRangeEnd = 207855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x001CCF30 File Offset: 0x001CB130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207855, XrefRangeEnd = 207884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x001CCF6C File Offset: 0x001CB16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207884, XrefRangeEnd = 207887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x001CCFA8 File Offset: 0x001CB1A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x001CCFE4 File Offset: 0x001CB1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207672, RefRangeEnd = 207674, XrefRangeStart = 207672, XrefRangeEnd = 207674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x001CD028 File Offset: 0x001CB228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207887, XrefRangeEnd = 207888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x001CD06C File Offset: 0x001CB26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207888, XrefRangeEnd = 207891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x001CD0D0 File Offset: 0x001CB2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207891, XrefRangeEnd = 207901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x001CD124 File Offset: 0x001CB324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207911, RefRangeEnd = 207913, XrefRangeStart = 207901, XrefRangeEnd = 207911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x001CD178 File Offset: 0x001CB378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207913, XrefRangeEnd = 207916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x001CD1C8 File Offset: 0x001CB3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207916, XrefRangeEnd = 207926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x001CD21C File Offset: 0x001CB41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207926, XrefRangeEnd = 207930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x001CD26C File Offset: 0x001CB46C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207951, RefRangeEnd = 207955, XrefRangeStart = 207930, XrefRangeEnd = 207951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref status;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x001CD2BC File Offset: 0x001CB4BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207963, RefRangeEnd = 207966, XrefRangeStart = 207955, XrefRangeEnd = 207963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref status;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x001CD30C File Offset: 0x001CB50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207966, XrefRangeEnd = 207971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x001CD35C File Offset: 0x001CB55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207971, XrefRangeEnd = 207974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0002F94C File Offset: 0x0002DB4C
		public DeliveryManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x001CD398 File Offset: 0x001CB598
		// (set) Token: 0x0600653E RID: 25918 RVA: 0x0002F955 File Offset: 0x0002DB55
		public unsafe List<DeliveryInstance> Deliveries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x001CD3C8 File Offset: 0x001CB5C8
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x0002F974 File Offset: 0x0002DB74
		public unsafe UnityEvent<DeliveryInstance> onDeliveryCreated
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x001CD3F8 File Offset: 0x001CB5F8
		// (set) Token: 0x06006542 RID: 25922 RVA: 0x0002F993 File Offset: 0x0002DB93
		public unsafe UnityEvent<DeliveryInstance> onDeliveryCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x001CD428 File Offset: 0x001CB628
		// (set) Token: 0x06006544 RID: 25924 RVA: 0x0002F9B2 File Offset: 0x0002DBB2
		public unsafe DeliveriesLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveriesLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x001CD458 File Offset: 0x001CB658
		// (set) Token: 0x06006546 RID: 25926 RVA: 0x0002F9D1 File Offset: 0x0002DBD1
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x001CD488 File Offset: 0x001CB688
		// (set) Token: 0x06006548 RID: 25928 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x001CD4B8 File Offset: 0x001CB6B8
		// (set) Token: 0x0600654A RID: 25930 RVA: 0x0002FA0F File Offset: 0x0002DC0F
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x001CD4E0 File Offset: 0x001CB6E0
		// (set) Token: 0x0600654C RID: 25932 RVA: 0x0002FA2A File Offset: 0x0002DC2A
		public unsafe List<string> writtenVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x001CD510 File Offset: 0x001CB710
		// (set) Token: 0x0600654E RID: 25934 RVA: 0x0002FA49 File Offset: 0x0002DC49
		public unsafe Dictionary<DeliveryInstance, int> minsSinceVehicleEmpty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DeliveryInstance, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x001CD540 File Offset: 0x001CB740
		// (set) Token: 0x06006550 RID: 25936 RVA: 0x0002FA68 File Offset: 0x0002DC68
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x001CD568 File Offset: 0x001CB768
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x0002FA83 File Offset: 0x0002DC83
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040044F6 RID: 17654
		private static readonly System.IntPtr NativeFieldInfoPtr_Deliveries;

		// Token: 0x040044F7 RID: 17655
		private static readonly System.IntPtr NativeFieldInfoPtr_onDeliveryCreated;

		// Token: 0x040044F8 RID: 17656
		private static readonly System.IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x040044F9 RID: 17657
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040044FA RID: 17658
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040044FB RID: 17659
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040044FC RID: 17660
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040044FD RID: 17661
		private static readonly System.IntPtr NativeFieldInfoPtr_writtenVehicles;

		// Token: 0x040044FE RID: 17662
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceVehicleEmpty;

		// Token: 0x040044FF RID: 17663
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004500 RID: 17664
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004501 RID: 17665
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004502 RID: 17666
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004503 RID: 17667
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004504 RID: 17668
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004505 RID: 17669
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004506 RID: 17670
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004507 RID: 17671
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004508 RID: 17672
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004509 RID: 17673
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400450A RID: 17674
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400450B RID: 17675
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400450C RID: 17676
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400450D RID: 17677
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400450E RID: 17678
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400450F RID: 17679
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04004510 RID: 17680
		private static readonly System.IntPtr NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0;

		// Token: 0x04004511 RID: 17681
		private static readonly System.IntPtr NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x04004512 RID: 17682
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04004513 RID: 17683
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04004514 RID: 17684
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0;

		// Token: 0x04004515 RID: 17685
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0;

		// Token: 0x04004516 RID: 17686
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0;

		// Token: 0x04004517 RID: 17687
		private static readonly System.IntPtr NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0;

		// Token: 0x04004518 RID: 17688
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004519 RID: 17689
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400451A RID: 17690
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400451B RID: 17691
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400451C RID: 17692
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400451D RID: 17693
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0;

		// Token: 0x0400451E RID: 17694
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0;

		// Token: 0x0400451F RID: 17695
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004520 RID: 17696
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04004521 RID: 17697
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04004522 RID: 17698
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004523 RID: 17699
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04004524 RID: 17700
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004525 RID: 17701
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04004526 RID: 17702
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04004527 RID: 17703
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004528 RID: 17704
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A72 RID: 2674
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D44D RID: 54349 RVA: 0x003323EC File Offset: 0x003305EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, "deliveryID");
				DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, 100676232);
				DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, 100676233);
			}

			// Token: 0x0600D44E RID: 54350 RVA: 0x00332454 File Offset: 0x00330654
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D44F RID: 54351 RVA: 0x00332490 File Offset: 0x00330690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D450 RID: 54352 RVA: 0x00066F6D File Offset: 0x0006516D
			public __c__DisplayClass35_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B1 RID: 16817
			// (get) Token: 0x0600D451 RID: 54353 RVA: 0x003324E0 File Offset: 0x003306E0
			// (set) Token: 0x0600D452 RID: 54354 RVA: 0x00066F76 File Offset: 0x00065176
			public unsafe string deliveryID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F4E RID: 36686
			private static readonly System.IntPtr NativeFieldInfoPtr_deliveryID;

			// Token: 0x04008F4F RID: 36687
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F50 RID: 36688
			private static readonly System.IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A73 RID: 2675
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D453 RID: 54355 RVA: 0x00332508 File Offset: 0x00330708
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, "destination");
				DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, 100676234);
				DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, 100676235);
			}

			// Token: 0x0600D454 RID: 54356 RVA: 0x00332570 File Offset: 0x00330770
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D455 RID: 54357 RVA: 0x003325AC File Offset: 0x003307AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207538, XrefRangeEnd = 207540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D456 RID: 54358 RVA: 0x00066F95 File Offset: 0x00065195
			public __c__DisplayClass36_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B2 RID: 16818
			// (get) Token: 0x0600D457 RID: 54359 RVA: 0x003325FC File Offset: 0x003307FC
			// (set) Token: 0x0600D458 RID: 54360 RVA: 0x00066F9E File Offset: 0x0006519E
			public unsafe Property destination
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F51 RID: 36689
			private static readonly System.IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008F52 RID: 36690
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F53 RID: 36691
			private static readonly System.IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A74 RID: 2676
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D459 RID: 54361 RVA: 0x0033262C File Offset: 0x0033082C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, "shop");
				DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, 100676236);
				DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, 100676237);
			}

			// Token: 0x0600D45A RID: 54362 RVA: 0x00332694 File Offset: 0x00330894
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D45B RID: 54363 RVA: 0x003326D0 File Offset: 0x003308D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207540, XrefRangeEnd = 207542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetActiveShopDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D45C RID: 54364 RVA: 0x00066FBD File Offset: 0x000651BD
			public __c__DisplayClass37_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B3 RID: 16819
			// (get) Token: 0x0600D45D RID: 54365 RVA: 0x00332720 File Offset: 0x00330920
			// (set) Token: 0x0600D45E RID: 54366 RVA: 0x00066FC6 File Offset: 0x000651C6
			public unsafe DeliveryShop shop
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F54 RID: 36692
			private static readonly System.IntPtr NativeFieldInfoPtr_shop;

			// Token: 0x04008F55 RID: 36693
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F56 RID: 36694
			private static readonly System.IntPtr NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A75 RID: 2677
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D45F RID: 54367 RVA: 0x00332750 File Offset: 0x00330950
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, "shopName");
				DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, 100676238);
				DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, 100676239);
			}

			// Token: 0x0600D460 RID: 54368 RVA: 0x003327B8 File Offset: 0x003309B8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D461 RID: 54369 RVA: 0x003327F4 File Offset: 0x003309F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShopInterface_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D462 RID: 54370 RVA: 0x00066FE5 File Offset: 0x000651E5
			public __c__DisplayClass38_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0600D463 RID: 54371 RVA: 0x00332844 File Offset: 0x00330A44
			// (set) Token: 0x0600D464 RID: 54372 RVA: 0x00066FEE File Offset: 0x000651EE
			public unsafe string shopName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F57 RID: 36695
			private static readonly System.IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x04008F58 RID: 36696
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F59 RID: 36697
			private static readonly System.IntPtr NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
