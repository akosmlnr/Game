using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000783 RID: 1923
	public class SoilPourer : GridItem
	{
		// Token: 0x0600B6A0 RID: 46752 RVA: 0x002DB508 File Offset: 0x002D9708
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourer()
		{
			Il2CppClassPointerStore<SoilPourer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "SoilPourer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr);
			SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<SoilID>k__BackingField");
			SoilPourer.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "AnimationDuration");
			SoilPourer.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "HandleIntObj");
			SoilPourer.NativeFieldInfoPtr_FillIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillIntObj");
			SoilPourer.NativeFieldInfoPtr_DirtPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPlane");
			SoilPourer.NativeFieldInfoPtr_Dirt_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Min");
			SoilPourer.NativeFieldInfoPtr_Dirt_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Max");
			SoilPourer.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourParticles");
			SoilPourer.NativeFieldInfoPtr_PourAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourAnimation");
			SoilPourer.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillSound");
			SoilPourer.NativeFieldInfoPtr_ActivateSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "ActivateSound");
			SoilPourer.NativeFieldInfoPtr_DirtPourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPourSound");
			SoilPourer.NativeFieldInfoPtr_isDispensing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "isDispensing");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685955);
			SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685956);
			SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685957);
			SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685958);
			SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685959);
			SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685960);
			SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685961);
			SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685962);
			SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685963);
			SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685964);
			SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685965);
			SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685966);
			SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685967);
			SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685968);
			SoilPourer.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685969);
			SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685970);
			SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685971);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685972);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685973);
			SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685974);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685975);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685976);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685977);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685978);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685979);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685980);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685981);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685982);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685983);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685984);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685985);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685986);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685987);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685988);
			SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685989);
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x002DB920 File Offset: 0x002D9B20
		// (set) Token: 0x0600B6A2 RID: 46754 RVA: 0x002DB958 File Offset: 0x002D9B58
		public unsafe string SoilID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x002DB99C File Offset: 0x002D9B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313833, XrefRangeEnd = 313842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x002DB9EC File Offset: 0x002D9BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313842, XrefRangeEnd = 313846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x002DBA20 File Offset: 0x002D9C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313846, XrefRangeEnd = 313867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x002DBA54 File Offset: 0x002D9C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313867, XrefRangeEnd = 313888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x002DBA88 File Offset: 0x002D9C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313909, RefRangeEnd = 313912, XrefRangeStart = 313888, XrefRangeEnd = 313909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x002DBABC File Offset: 0x002D9CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313912, XrefRangeEnd = 313925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x002DBB00 File Offset: 0x002D9D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313925, XrefRangeEnd = 313943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x002DBB34 File Offset: 0x002D9D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313943, XrefRangeEnd = 313987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x002DBB68 File Offset: 0x002D9D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314009, RefRangeEnd = 314011, XrefRangeStart = 313987, XrefRangeEnd = 314009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x002DBBAC File Offset: 0x002D9DAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314053, RefRangeEnd = 314057, XrefRangeStart = 314011, XrefRangeEnd = 314053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoil(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x002DBC00 File Offset: 0x002D9E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314065, RefRangeEnd = 314067, XrefRangeStart = 314057, XrefRangeEnd = 314065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x002DBC40 File Offset: 0x002D9E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314067, XrefRangeEnd = 314126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x002DBC8C File Offset: 0x002D9E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314126, XrefRangeEnd = 314130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x002DBCD8 File Offset: 0x002D9ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314130, XrefRangeEnd = 314134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x002DBD14 File Offset: 0x002D9F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314134, XrefRangeEnd = 314139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x002DBD54 File Offset: 0x002D9F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314139, XrefRangeEnd = 314172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x002DBD90 File Offset: 0x002D9F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314172, XrefRangeEnd = 314173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x002DBDCC File Offset: 0x002D9FCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x002DBE08 File Offset: 0x002DA008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314173, XrefRangeEnd = 314182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x002DBE3C File Offset: 0x002DA03C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313909, RefRangeEnd = 313912, XrefRangeStart = 313909, XrefRangeEnd = 313912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x002DBE70 File Offset: 0x002DA070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314182, XrefRangeEnd = 314185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x002DBED4 File Offset: 0x002DA0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314185, XrefRangeEnd = 314194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002DBF08 File Offset: 0x002DA108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314200, RefRangeEnd = 314203, XrefRangeStart = 314194, XrefRangeEnd = 314200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002DBF3C File Offset: 0x002DA13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314203, XrefRangeEnd = 314206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x002DBF8C File Offset: 0x002DA18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314206, XrefRangeEnd = 314216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x002DBFD0 File Offset: 0x002DA1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314216, XrefRangeEnd = 314217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x002DC014 File Offset: 0x002DA214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314217, XrefRangeEnd = 314221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x002DC078 File Offset: 0x002DA278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314221, XrefRangeEnd = 314231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x002DC0CC File Offset: 0x002DA2CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314240, RefRangeEnd = 314243, XrefRangeStart = 314231, XrefRangeEnd = 314240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x002DC120 File Offset: 0x002DA320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314243, XrefRangeEnd = 314247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x002DC170 File Offset: 0x002DA370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314247, XrefRangeEnd = 314257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x002DC1C4 File Offset: 0x002DA3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314257, XrefRangeEnd = 314261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x002DC214 File Offset: 0x002DA414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296649, RefRangeEnd = 296650, XrefRangeStart = 296649, XrefRangeEnd = 296650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x0005931B File Offset: 0x0005751B
		public SoilPourer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B6C5 RID: 46789 RVA: 0x002DC250 File Offset: 0x002DA450
		// (set) Token: 0x0600B6C6 RID: 46790 RVA: 0x00059324 File Offset: 0x00057524
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600B6C7 RID: 46791 RVA: 0x002DC278 File Offset: 0x002DA478
		// (set) Token: 0x0600B6C8 RID: 46792 RVA: 0x00059343 File Offset: 0x00057543
		public unsafe float AnimationDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600B6C9 RID: 46793 RVA: 0x002DC2A0 File Offset: 0x002DA4A0
		// (set) Token: 0x0600B6CA RID: 46794 RVA: 0x0005935E File Offset: 0x0005755E
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600B6CB RID: 46795 RVA: 0x002DC2D0 File Offset: 0x002DA4D0
		// (set) Token: 0x0600B6CC RID: 46796 RVA: 0x0005937D File Offset: 0x0005757D
		public unsafe InteractableObject FillIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600B6CD RID: 46797 RVA: 0x002DC300 File Offset: 0x002DA500
		// (set) Token: 0x0600B6CE RID: 46798 RVA: 0x0005939C File Offset: 0x0005759C
		public unsafe MeshRenderer DirtPlane
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x002DC330 File Offset: 0x002DA530
		// (set) Token: 0x0600B6D0 RID: 46800 RVA: 0x000593BB File Offset: 0x000575BB
		public unsafe Transform Dirt_Min
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x002DC360 File Offset: 0x002DA560
		// (set) Token: 0x0600B6D2 RID: 46802 RVA: 0x000593DA File Offset: 0x000575DA
		public unsafe Transform Dirt_Max
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x002DC390 File Offset: 0x002DA590
		// (set) Token: 0x0600B6D4 RID: 46804 RVA: 0x000593F9 File Offset: 0x000575F9
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002DC3C0 File Offset: 0x002DA5C0
		// (set) Token: 0x0600B6D6 RID: 46806 RVA: 0x00059418 File Offset: 0x00057618
		public unsafe Animation PourAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600B6D7 RID: 46807 RVA: 0x002DC3F0 File Offset: 0x002DA5F0
		// (set) Token: 0x0600B6D8 RID: 46808 RVA: 0x00059437 File Offset: 0x00057637
		public unsafe AudioSourceController FillSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002DC420 File Offset: 0x002DA620
		// (set) Token: 0x0600B6DA RID: 46810 RVA: 0x00059456 File Offset: 0x00057656
		public unsafe AudioSourceController ActivateSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x002DC450 File Offset: 0x002DA650
		// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x00059475 File Offset: 0x00057675
		public unsafe AudioSourceController DirtPourSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x002DC480 File Offset: 0x002DA680
		// (set) Token: 0x0600B6DE RID: 46814 RVA: 0x00059494 File Offset: 0x00057694
		public unsafe bool isDispensing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing)) = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x002DC4A8 File Offset: 0x002DA6A8
		// (set) Token: 0x0600B6E0 RID: 46816 RVA: 0x000594AF File Offset: 0x000576AF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x002DC4D0 File Offset: 0x002DA6D0
		// (set) Token: 0x0600B6E2 RID: 46818 RVA: 0x000594CA File Offset: 0x000576CA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007B4D RID: 31565
		private static readonly System.IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x04007B4E RID: 31566
		private static readonly System.IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x04007B4F RID: 31567
		private static readonly System.IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04007B50 RID: 31568
		private static readonly System.IntPtr NativeFieldInfoPtr_FillIntObj;

		// Token: 0x04007B51 RID: 31569
		private static readonly System.IntPtr NativeFieldInfoPtr_DirtPlane;

		// Token: 0x04007B52 RID: 31570
		private static readonly System.IntPtr NativeFieldInfoPtr_Dirt_Min;

		// Token: 0x04007B53 RID: 31571
		private static readonly System.IntPtr NativeFieldInfoPtr_Dirt_Max;

		// Token: 0x04007B54 RID: 31572
		private static readonly System.IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04007B55 RID: 31573
		private static readonly System.IntPtr NativeFieldInfoPtr_PourAnimation;

		// Token: 0x04007B56 RID: 31574
		private static readonly System.IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x04007B57 RID: 31575
		private static readonly System.IntPtr NativeFieldInfoPtr_ActivateSound;

		// Token: 0x04007B58 RID: 31576
		private static readonly System.IntPtr NativeFieldInfoPtr_DirtPourSound;

		// Token: 0x04007B59 RID: 31577
		private static readonly System.IntPtr NativeFieldInfoPtr_isDispensing;

		// Token: 0x04007B5A RID: 31578
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007B5B RID: 31579
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007B5C RID: 31580
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x04007B5D RID: 31581
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x04007B5E RID: 31582
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007B5F RID: 31583
		private static readonly System.IntPtr NativeMethodInfoPtr_HandleHovered_Public_Void_0;

		// Token: 0x04007B60 RID: 31584
		private static readonly System.IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04007B61 RID: 31585
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPourSoil_Private_Void_0;

		// Token: 0x04007B62 RID: 31586
		private static readonly System.IntPtr NativeMethodInfoPtr_PourSoil_Private_Void_0;

		// Token: 0x04007B63 RID: 31587
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplySoil_Private_Void_String_0;

		// Token: 0x04007B64 RID: 31588
		private static readonly System.IntPtr NativeMethodInfoPtr_FillHovered_Public_Void_0;

		// Token: 0x04007B65 RID: 31589
		private static readonly System.IntPtr NativeMethodInfoPtr_FillInteracted_Public_Void_0;

		// Token: 0x04007B66 RID: 31590
		private static readonly System.IntPtr NativeMethodInfoPtr_SendSoil_Public_Void_String_0;

		// Token: 0x04007B67 RID: 31591
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0;

		// Token: 0x04007B68 RID: 31592
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0;

		// Token: 0x04007B69 RID: 31593
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x04007B6A RID: 31594
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04007B6B RID: 31595
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007B6C RID: 31596
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007B6D RID: 31597
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007B6E RID: 31598
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007B6F RID: 31599
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007B70 RID: 31600
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x04007B71 RID: 31601
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x04007B72 RID: 31602
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007B73 RID: 31603
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0;

		// Token: 0x04007B74 RID: 31604
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0;

		// Token: 0x04007B75 RID: 31605
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007B76 RID: 31606
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0;

		// Token: 0x04007B77 RID: 31607
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0;

		// Token: 0x04007B78 RID: 31608
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007B79 RID: 31609
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04007B7A RID: 31610
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0;

		// Token: 0x04007B7B RID: 31611
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007B7C RID: 31612
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04007B7D RID: 31613
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007B7E RID: 31614
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C51 RID: 3153
		[ObfuscatedName("ScheduleOne.ObjectScripts.SoilPourer+<<PourSoil>g__PourRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E52E RID: 58670 RVA: 0x00361DFC File Offset: 0x0035FFFC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<<PourSoil>g__PourRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<targetPot>5__2");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<i>5__3");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685990);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685991);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685992);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685993);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685994);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685995);
			}

			// Token: 0x0600E52F RID: 58671 RVA: 0x00361F04 File Offset: 0x00360104
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E530 RID: 58672 RVA: 0x00361F4C File Offset: 0x0036014C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E531 RID: 58673 RVA: 0x00361F80 File Offset: 0x00360180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313819, XrefRangeEnd = 313828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046BA RID: 18106
			// (get) Token: 0x0600E532 RID: 58674 RVA: 0x00361FBC File Offset: 0x003601BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E533 RID: 58675 RVA: 0x00361FFC File Offset: 0x003601FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313828, XrefRangeEnd = 313833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046BB RID: 18107
			// (get) Token: 0x0600E534 RID: 58676 RVA: 0x00362030 File Offset: 0x00360230
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E535 RID: 58677 RVA: 0x0006F70E File Offset: 0x0006D90E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046B5 RID: 18101
			// (get) Token: 0x0600E536 RID: 58678 RVA: 0x00362070 File Offset: 0x00360270
			// (set) Token: 0x0600E537 RID: 58679 RVA: 0x0006F717 File Offset: 0x0006D917
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046B6 RID: 18102
			// (get) Token: 0x0600E538 RID: 58680 RVA: 0x00362098 File Offset: 0x00360298
			// (set) Token: 0x0600E539 RID: 58681 RVA: 0x0006F732 File Offset: 0x0006D932
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B7 RID: 18103
			// (get) Token: 0x0600E53A RID: 58682 RVA: 0x003620C8 File Offset: 0x003602C8
			// (set) Token: 0x0600E53B RID: 58683 RVA: 0x0006F751 File Offset: 0x0006D951
			public unsafe SoilPourer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilPourer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B8 RID: 18104
			// (get) Token: 0x0600E53C RID: 58684 RVA: 0x003620F8 File Offset: 0x003602F8
			// (set) Token: 0x0600E53D RID: 58685 RVA: 0x0006F770 File Offset: 0x0006D970
			public unsafe Pot _targetPot_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B9 RID: 18105
			// (get) Token: 0x0600E53E RID: 58686 RVA: 0x00362128 File Offset: 0x00360328
			// (set) Token: 0x0600E53F RID: 58687 RVA: 0x0006F78F File Offset: 0x0006D98F
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400998F RID: 39311
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009990 RID: 39312
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009991 RID: 39313
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009992 RID: 39314
			private static readonly System.IntPtr NativeFieldInfoPtr__targetPot_5__2;

			// Token: 0x04009993 RID: 39315
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009994 RID: 39316
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009995 RID: 39317
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009996 RID: 39318
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009997 RID: 39319
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009998 RID: 39320
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009999 RID: 39321
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
