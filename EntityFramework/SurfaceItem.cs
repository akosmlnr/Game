using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000422 RID: 1058
	public class SurfaceItem : BuildableItem
	{
		// Token: 0x0600579E RID: 22430 RVA: 0x0019B2AC File Offset: 0x001994AC
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItem()
		{
			Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr);
			SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<ParentSurface>k__BackingField");
			SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "ValidSurfaceTypes");
			SurfaceItem.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "AllowRotation");
			SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<RotationIncrement>k__BackingField");
			SurfaceItem.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "RelativePosition");
			SurfaceItem.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "RelativeRotation");
			SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted");
			SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted");
			SurfaceItem.NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674343);
			SurfaceItem.NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674344);
			SurfaceItem.NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674345);
			SurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674346);
			SurfaceItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674347);
			SurfaceItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674348);
			SurfaceItem.NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674349);
			SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674350);
			SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674351);
			SurfaceItem.NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674352);
			SurfaceItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674353);
			SurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674354);
			SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674355);
			SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674356);
			SurfaceItem.NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674357);
			SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674358);
			SurfaceItem.NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674359);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674360);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674361);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674362);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674363);
			SurfaceItem.NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674364);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674365);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674366);
			SurfaceItem.NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674367);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674368);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674369);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674370);
			SurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674371);
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x0019B5C0 File Offset: 0x001997C0
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x0019B600 File Offset: 0x00199800
		public unsafe Surface ParentSurface
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x0019B644 File Offset: 0x00199844
		public unsafe float RotationIncrement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x0019B680 File Offset: 0x00199880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186919, RefRangeEnd = 186921, XrefRangeStart = 186918, XrefRangeEnd = 186919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x0019B6BC File Offset: 0x001998BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186921, XrefRangeEnd = 186928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x0019B6F8 File Offset: 0x001998F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186928, XrefRangeEnd = 186930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x0019B748 File Offset: 0x00199948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186930, XrefRangeEnd = 186931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSurfaceItemData(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x0019B7CC File Offset: 0x001999CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186931, XrefRangeEnd = 186932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSurfaceItem(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x0019B86C File Offset: 0x00199A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186932, XrefRangeEnd = 186951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x0019B8FC File Offset: 0x00199AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186951, XrefRangeEnd = 186980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x0019B968 File Offset: 0x00199B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186980, XrefRangeEnd = 186981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x0019B9C4 File Offset: 0x00199BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186981, XrefRangeEnd = 186986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x0019BA10 File Offset: 0x00199C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187007, RefRangeEnd = 187009, XrefRangeStart = 186986, XrefRangeEnd = 187007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x0019BA4C File Offset: 0x00199C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187009, XrefRangeEnd = 187014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x0019BA8C File Offset: 0x00199C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x0019BAC8 File Offset: 0x00199CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187014, XrefRangeEnd = 187019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x0019BB08 File Offset: 0x00199D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetTransformData_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x0019BB44 File Offset: 0x00199D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187040, RefRangeEnd = 187042, XrefRangeStart = 187019, XrefRangeEnd = 187040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0019BB80 File Offset: 0x00199D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187043, RefRangeEnd = 187045, XrefRangeStart = 187042, XrefRangeEnd = 187043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x0019BBBC File Offset: 0x00199DBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x0019BBF8 File Offset: 0x00199DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187072, RefRangeEnd = 187074, XrefRangeStart = 187045, XrefRangeEnd = 187072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x0019BC7C File Offset: 0x00199E7C
		[CallerCount(0)]
		public unsafe void RpcLogic___SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x0019BD00 File Offset: 0x00199F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187074, XrefRangeEnd = 187083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSurfaceItemData_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x0019BD64 File Offset: 0x00199F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187110, RefRangeEnd = 187111, XrefRangeStart = 187083, XrefRangeEnd = 187110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x0019BDFC File Offset: 0x00199FFC
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x0019BE9C File Offset: 0x0019A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187111, XrefRangeEnd = 187121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x0019BEEC File Offset: 0x0019A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187121, XrefRangeEnd = 187148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x0019BF84 File Offset: 0x0019A184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187148, XrefRangeEnd = 187158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x0019BFD4 File Offset: 0x0019A1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187158, XrefRangeEnd = 187159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00029B27 File Offset: 0x00027D27
		public SurfaceItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x060057BD RID: 22461 RVA: 0x0019C010 File Offset: 0x0019A210
		// (set) Token: 0x060057BE RID: 22462 RVA: 0x00029B30 File Offset: 0x00027D30
		public unsafe Surface _ParentSurface_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x0019C040 File Offset: 0x0019A240
		// (set) Token: 0x060057C0 RID: 22464 RVA: 0x00029B4F File Offset: 0x00027D4F
		public unsafe List<Surface.ESurfaceType> ValidSurfaceTypes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.ESurfaceType>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x0019C070 File Offset: 0x0019A270
		// (set) Token: 0x060057C2 RID: 22466 RVA: 0x00029B6E File Offset: 0x00027D6E
		public unsafe bool AllowRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x0019C098 File Offset: 0x0019A298
		// (set) Token: 0x060057C4 RID: 22468 RVA: 0x00029B89 File Offset: 0x00027D89
		public unsafe float _RotationIncrement_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x0019C0C0 File Offset: 0x0019A2C0
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x00029BA4 File Offset: 0x00027DA4
		public unsafe Vector3 RelativePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x0019C0E8 File Offset: 0x0019A2E8
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x00029BBF File Offset: 0x00027DBF
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x0019C110 File Offset: 0x0019A310
		// (set) Token: 0x060057CA RID: 22474 RVA: 0x00029BDA File Offset: 0x00027DDA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x0019C138 File Offset: 0x0019A338
		// (set) Token: 0x060057CC RID: 22476 RVA: 0x00029BF5 File Offset: 0x00027DF5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B66 RID: 15206
		private static readonly System.IntPtr NativeFieldInfoPtr__ParentSurface_k__BackingField;

		// Token: 0x04003B67 RID: 15207
		private static readonly System.IntPtr NativeFieldInfoPtr_ValidSurfaceTypes;

		// Token: 0x04003B68 RID: 15208
		private static readonly System.IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x04003B69 RID: 15209
		private static readonly System.IntPtr NativeFieldInfoPtr__RotationIncrement_k__BackingField;

		// Token: 0x04003B6A RID: 15210
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x04003B6B RID: 15211
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x04003B6C RID: 15212
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003B6D RID: 15213
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003B6E RID: 15214
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0;

		// Token: 0x04003B6F RID: 15215
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0;

		// Token: 0x04003B70 RID: 15216
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0;

		// Token: 0x04003B71 RID: 15217
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003B72 RID: 15218
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003B73 RID: 15219
		private static readonly System.IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003B74 RID: 15220
		private static readonly System.IntPtr NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B75 RID: 15221
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B76 RID: 15222
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B77 RID: 15223
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0;

		// Token: 0x04003B78 RID: 15224
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0;

		// Token: 0x04003B79 RID: 15225
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04003B7A RID: 15226
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B7B RID: 15227
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003B7C RID: 15228
		private static readonly System.IntPtr NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0;

		// Token: 0x04003B7D RID: 15229
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003B7E RID: 15230
		private static readonly System.IntPtr NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0;

		// Token: 0x04003B7F RID: 15231
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B80 RID: 15232
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B81 RID: 15233
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B82 RID: 15234
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B83 RID: 15235
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B84 RID: 15236
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B85 RID: 15237
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B86 RID: 15238
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B87 RID: 15239
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B88 RID: 15240
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003B89 RID: 15241
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B8A RID: 15242
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A10 RID: 2576
		[ObfuscatedName("ScheduleOne.EntityFramework.SurfaceItem+<<OnStartClient>g__WaitForDataSend|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D18C RID: 53644 RVA: 0x0032A7F8 File Offset: 0x003289F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674372);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674373);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674374);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674375);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674376);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674377);
			}

			// Token: 0x0600D18D RID: 53645 RVA: 0x0032A8D8 File Offset: 0x00328AD8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D18E RID: 53646 RVA: 0x0032A920 File Offset: 0x00328B20
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D18F RID: 53647 RVA: 0x0032A954 File Offset: 0x00328B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186882, XrefRangeEnd = 186897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040FA RID: 16634
			// (get) Token: 0x0600D190 RID: 53648 RVA: 0x0032A990 File Offset: 0x00328B90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D191 RID: 53649 RVA: 0x0032A9D0 File Offset: 0x00328BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186897, XrefRangeEnd = 186902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040FB RID: 16635
			// (get) Token: 0x0600D192 RID: 53650 RVA: 0x0032AA04 File Offset: 0x00328C04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D193 RID: 53651 RVA: 0x00065992 File Offset: 0x00063B92
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F7 RID: 16631
			// (get) Token: 0x0600D194 RID: 53652 RVA: 0x0032AA44 File Offset: 0x00328C44
			// (set) Token: 0x0600D195 RID: 53653 RVA: 0x0006599B File Offset: 0x00063B9B
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040F8 RID: 16632
			// (get) Token: 0x0600D196 RID: 53654 RVA: 0x0032AA6C File Offset: 0x00328C6C
			// (set) Token: 0x0600D197 RID: 53655 RVA: 0x000659B6 File Offset: 0x00063BB6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F9 RID: 16633
			// (get) Token: 0x0600D198 RID: 53656 RVA: 0x0032AA9C File Offset: 0x00328C9C
			// (set) Token: 0x0600D199 RID: 53657 RVA: 0x000659D5 File Offset: 0x00063BD5
			public unsafe SurfaceItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DB2 RID: 36274
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DB3 RID: 36275
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DB4 RID: 36276
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DB5 RID: 36277
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DB6 RID: 36278
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DB7 RID: 36279
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DB8 RID: 36280
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DB9 RID: 36281
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DBA RID: 36282
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A11 RID: 2577
		[ObfuscatedName("ScheduleOne.EntityFramework.SurfaceItem+<<SetTransformData>g__Routine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D19A RID: 53658 RVA: 0x0032AACC File Offset: 0x00328CCC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<<SetTransformData>g__Routine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674378);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674379);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674380);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674381);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674382);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674383);
			}

			// Token: 0x0600D19B RID: 53659 RVA: 0x0032ABAC File Offset: 0x00328DAC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D19C RID: 53660 RVA: 0x0032ABF4 File Offset: 0x00328DF4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D19D RID: 53661 RVA: 0x0032AC28 File Offset: 0x00328E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186902, XrefRangeEnd = 186913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040FF RID: 16639
			// (get) Token: 0x0600D19E RID: 53662 RVA: 0x0032AC64 File Offset: 0x00328E64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D19F RID: 53663 RVA: 0x0032ACA4 File Offset: 0x00328EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186913, XrefRangeEnd = 186918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004100 RID: 16640
			// (get) Token: 0x0600D1A0 RID: 53664 RVA: 0x0032ACD8 File Offset: 0x00328ED8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D1A1 RID: 53665 RVA: 0x000659F4 File Offset: 0x00063BF4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040FC RID: 16636
			// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x0032AD18 File Offset: 0x00328F18
			// (set) Token: 0x0600D1A3 RID: 53667 RVA: 0x000659FD File Offset: 0x00063BFD
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040FD RID: 16637
			// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x0032AD40 File Offset: 0x00328F40
			// (set) Token: 0x0600D1A5 RID: 53669 RVA: 0x00065A18 File Offset: 0x00063C18
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040FE RID: 16638
			// (get) Token: 0x0600D1A6 RID: 53670 RVA: 0x0032AD70 File Offset: 0x00328F70
			// (set) Token: 0x0600D1A7 RID: 53671 RVA: 0x00065A37 File Offset: 0x00063C37
			public unsafe SurfaceItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DBB RID: 36283
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DBC RID: 36284
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DBD RID: 36285
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DBE RID: 36286
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DBF RID: 36287
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DC0 RID: 36288
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DC1 RID: 36289
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DC2 RID: 36290
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DC3 RID: 36291
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
