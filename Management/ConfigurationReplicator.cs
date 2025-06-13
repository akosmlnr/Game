using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A2 RID: 930
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x06004788 RID: 18312 RVA: 0x00160B98 File Offset: 0x0015ED98
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationReplicator()
		{
			Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurationReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr);
			ConfigurationReplicator.NativeFieldInfoPtr_Configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "Configuration");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672166);
			ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672167);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672168);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672169);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672170);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672171);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672172);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672173);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672174);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672175);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672176);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672177);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672178);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672179);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672180);
			ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672181);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672182);
			ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672183);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672184);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672185);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672186);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672187);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672188);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672189);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672190);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672191);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672192);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672193);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672194);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672195);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672196);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672197);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672198);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672199);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672200);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672201);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672202);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672203);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672204);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672205);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672206);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672207);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672208);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672209);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672210);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672211);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672212);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672213);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672214);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672215);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672216);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672217);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672218);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672219);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672220);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672221);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672222);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672223);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672224);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672225);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672226);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672227);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672228);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672229);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672230);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672231);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672232);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672233);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672234);
			ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100672235);
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0016117C File Offset: 0x0015F37C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163026, RefRangeEnd = 163030, XrefRangeStart = 162808, XrefRangeEnd = 163026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x001611D0 File Offset: 0x0015F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163030, XrefRangeEnd = 163042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00161220 File Offset: 0x0015F420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163042, XrefRangeEnd = 163054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00161270 File Offset: 0x0015F470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163054, XrefRangeEnd = 163066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x001612C0 File Offset: 0x0015F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163066, XrefRangeEnd = 163078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00161310 File Offset: 0x0015F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163078, XrefRangeEnd = 163090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00161360 File Offset: 0x0015F560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163090, XrefRangeEnd = 163102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x001613B0 File Offset: 0x0015F5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163102, XrefRangeEnd = 163114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00161400 File Offset: 0x0015F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163114, XrefRangeEnd = 163126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00161450 File Offset: 0x0015F650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163126, XrefRangeEnd = 163139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0016149C File Offset: 0x0015F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163139, XrefRangeEnd = 163152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x001614E8 File Offset: 0x0015F6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163152, XrefRangeEnd = 163164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00161534 File Offset: 0x0015F734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163164, XrefRangeEnd = 163176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00161580 File Offset: 0x0015F780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163176, XrefRangeEnd = 163188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x001615D0 File Offset: 0x0015F7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163188, XrefRangeEnd = 163200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00161620 File Offset: 0x0015F820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163200, XrefRangeEnd = 163212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQualityField(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0016166C File Offset: 0x0015F86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163212, XrefRangeEnd = 163224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQualityField(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x001616B8 File Offset: 0x0015F8B8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x001616F4 File Offset: 0x0015F8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163224, XrefRangeEnd = 163322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00161730 File Offset: 0x0015F930
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x0016176C File Offset: 0x0015F96C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x001617A8 File Offset: 0x0015F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x001617F8 File Offset: 0x0015F9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x00161848 File Offset: 0x0015FA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163322, XrefRangeEnd = 163338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x001618AC File Offset: 0x0015FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x001618FC File Offset: 0x0015FAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163338, XrefRangeEnd = 163355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x0016194C File Offset: 0x0015FB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163355, XrefRangeEnd = 163376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0016199C File Offset: 0x0015FB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x001619EC File Offset: 0x0015FBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00161A3C File Offset: 0x0015FC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163376, XrefRangeEnd = 163392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00161AA0 File Offset: 0x0015FCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00161AF0 File Offset: 0x0015FCF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163416, RefRangeEnd = 163417, XrefRangeStart = 163392, XrefRangeEnd = 163416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00161B40 File Offset: 0x0015FD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163417, XrefRangeEnd = 163422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00161B90 File Offset: 0x0015FD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x00161BE0 File Offset: 0x0015FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00161C30 File Offset: 0x0015FE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163422, XrefRangeEnd = 163438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x00161C94 File Offset: 0x0015FE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x00161CE4 File Offset: 0x0015FEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163438, XrefRangeEnd = 163456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00161D34 File Offset: 0x0015FF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163456, XrefRangeEnd = 163477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00161D84 File Offset: 0x0015FF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x00161DD4 File Offset: 0x0015FFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x00161E24 File Offset: 0x00160024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163477, XrefRangeEnd = 163493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x00161E88 File Offset: 0x00160088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x00161ED8 File Offset: 0x001600D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163521, RefRangeEnd = 163522, XrefRangeStart = 163493, XrefRangeEnd = 163521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x00161F28 File Offset: 0x00160128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163522, XrefRangeEnd = 163527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x00161F78 File Offset: 0x00160178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x00161FC4 File Offset: 0x001601C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00162010 File Offset: 0x00160210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163527, XrefRangeEnd = 163545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x00162074 File Offset: 0x00160274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x001620C0 File Offset: 0x001602C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163545, XrefRangeEnd = 163557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref recipeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0016210C File Offset: 0x0016030C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163557, XrefRangeEnd = 163573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0016215C File Offset: 0x0016035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x001621A8 File Offset: 0x001603A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x001621F4 File Offset: 0x001603F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163573, XrefRangeEnd = 163589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x00162258 File Offset: 0x00160458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x001622A4 File Offset: 0x001604A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163589, XrefRangeEnd = 163596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x001622F0 File Offset: 0x001604F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163596, XrefRangeEnd = 163606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x00162340 File Offset: 0x00160540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x00162390 File Offset: 0x00160590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x001623E0 File Offset: 0x001605E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163606, XrefRangeEnd = 163622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00162444 File Offset: 0x00160644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00162494 File Offset: 0x00160694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163655, RefRangeEnd = 163656, XrefRangeStart = 163622, XrefRangeEnd = 163655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x001624E4 File Offset: 0x001606E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163656, XrefRangeEnd = 163661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x00162534 File Offset: 0x00160734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00162580 File Offset: 0x00160780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x001625CC File Offset: 0x001607CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163661, XrefRangeEnd = 163677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00162630 File Offset: 0x00160830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0016267C File Offset: 0x0016087C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163677, XrefRangeEnd = 163684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x001626C8 File Offset: 0x001608C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163684, XrefRangeEnd = 163694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x00162718 File Offset: 0x00160918
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00022A74 File Offset: 0x00020C74
		public ConfigurationReplicator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00162754 File Offset: 0x00160954
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00022A7D File Offset: 0x00020C7D
		public unsafe EntityConfiguration Configuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00162784 File Offset: 0x00160984
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00022A9C File Offset: 0x00020C9C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x001627AC File Offset: 0x001609AC
		// (set) Token: 0x060047D5 RID: 18389 RVA: 0x00022AB7 File Offset: 0x00020CB7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002FFB RID: 12283
		private static readonly System.IntPtr NativeFieldInfoPtr_Configuration;

		// Token: 0x04002FFC RID: 12284
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002FFD RID: 12285
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002FFE RID: 12286
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly System.IntPtr NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0;

		// Token: 0x04003000 RID: 12288
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0;

		// Token: 0x04003001 RID: 12289
		private static readonly System.IntPtr NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003002 RID: 12290
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003003 RID: 12291
		private static readonly System.IntPtr NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003004 RID: 12292
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003005 RID: 12293
		private static readonly System.IntPtr NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04003006 RID: 12294
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04003007 RID: 12295
		private static readonly System.IntPtr NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04003008 RID: 12296
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04003009 RID: 12297
		private static readonly System.IntPtr NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0;

		// Token: 0x0400300A RID: 12298
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0;

		// Token: 0x0400300B RID: 12299
		private static readonly System.IntPtr NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400300C RID: 12300
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400300D RID: 12301
		private static readonly System.IntPtr NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x0400300E RID: 12302
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x0400300F RID: 12303
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003010 RID: 12304
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003011 RID: 12305
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003012 RID: 12306
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003013 RID: 12307
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04003014 RID: 12308
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04003015 RID: 12309
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003016 RID: 12310
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04003017 RID: 12311
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04003018 RID: 12312
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003019 RID: 12313
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x0400301A RID: 12314
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x0400301B RID: 12315
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400301C RID: 12316
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x0400301D RID: 12317
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x0400301E RID: 12318
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400301F RID: 12319
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003020 RID: 12320
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003021 RID: 12321
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003022 RID: 12322
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003023 RID: 12323
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04003024 RID: 12324
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003025 RID: 12325
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04003026 RID: 12326
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04003027 RID: 12327
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003028 RID: 12328
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04003029 RID: 12329
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x0400302A RID: 12330
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400302B RID: 12331
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400302C RID: 12332
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400302D RID: 12333
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400302E RID: 12334
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400302F RID: 12335
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003030 RID: 12336
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003031 RID: 12337
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04003032 RID: 12338
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04003033 RID: 12339
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003034 RID: 12340
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04003035 RID: 12341
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04003036 RID: 12342
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003037 RID: 12343
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04003038 RID: 12344
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04003039 RID: 12345
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400303A RID: 12346
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400303B RID: 12347
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400303C RID: 12348
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400303D RID: 12349
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x0400303E RID: 12350
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x0400303F RID: 12351
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003040 RID: 12352
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04003041 RID: 12353
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04003042 RID: 12354
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003043 RID: 12355
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009C1 RID: 2497
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CEC9 RID: 52937 RVA: 0x00322A64 File Offset: 0x00320C64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr);
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__1_0");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__15_0");
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100672237);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100672238);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100672239);
			}

			// Token: 0x0600CECA RID: 52938 RVA: 0x00322B08 File Offset: 0x00320D08
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CECB RID: 52939 RVA: 0x00322B44 File Offset: 0x00320D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162802, XrefRangeEnd = 162804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRouteData _ReplicateField_b__1_0(AdvancedTransitRoute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr2) : null;
			}

			// Token: 0x0600CECC RID: 52940 RVA: 0x00322B94 File Offset: 0x00320D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162804, XrefRangeEnd = 162808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRoute _ReceiveRouteListField_b__15_0(AdvancedTransitRouteData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}

			// Token: 0x0600CECD RID: 52941 RVA: 0x000643E6 File Offset: 0x000625E6
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004027 RID: 16423
			// (get) Token: 0x0600CECE RID: 52942 RVA: 0x00322BE4 File Offset: 0x00320DE4
			// (set) Token: 0x0600CECF RID: 52943 RVA: 0x000643EF File Offset: 0x000625EF
			public unsafe static ConfigurationReplicator.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004028 RID: 16424
			// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x00322C0C File Offset: 0x00320E0C
			// (set) Token: 0x0600CED1 RID: 52945 RVA: 0x00064401 File Offset: 0x00062601
			public unsafe static Il2CppSystem.Func<AdvancedTransitRoute, AdvancedTransitRouteData> __9__1_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AdvancedTransitRoute, AdvancedTransitRouteData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004029 RID: 16425
			// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x00322C34 File Offset: 0x00320E34
			// (set) Token: 0x0600CED3 RID: 52947 RVA: 0x00064413 File Offset: 0x00062613
			public unsafe static Il2CppSystem.Func<AdvancedTransitRouteData, AdvancedTransitRoute> __9__15_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AdvancedTransitRouteData, AdvancedTransitRoute>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF8 RID: 35832
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BF9 RID: 35833
			private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008BFA RID: 35834
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04008BFB RID: 35835
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BFC RID: 35836
			private static readonly System.IntPtr NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0;

			// Token: 0x04008BFD RID: 35837
			private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0;
		}
	}
}
