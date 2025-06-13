using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000540 RID: 1344
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x0600769D RID: 30365 RVA: 0x00206B4C File Offset: 0x00204D4C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainer()
		{
			Il2CppClassPointerStore<TrashContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr);
			TrashContainer.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "<Content>k__BackingField");
			TrashContainer.NativeFieldInfoPtr_TrashCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashCapacity");
			TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashBagDropLocation");
			TrashContainer.NativeFieldInfoPtr_onTrashAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashAdded");
			TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashLevelChanged");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678296);
			TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678297);
			TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678298);
			TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678299);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678300);
			TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678301);
			TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678302);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678303);
			TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678304);
			TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678305);
			TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678306);
			TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678307);
			TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678308);
			TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678309);
			TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678310);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678311);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678312);
			TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678313);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678314);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678315);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678316);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678317);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678318);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678319);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678320);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678321);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678322);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678323);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678324);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678325);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678326);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678327);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678328);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678329);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678330);
			TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100678331);
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x00206ED8 File Offset: 0x002050D8
		// (set) Token: 0x0600769F RID: 30367 RVA: 0x00206F18 File Offset: 0x00205118
		public unsafe TrashContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x00206F5C File Offset: 0x0020515C
		public unsafe int TrashLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 231567, RefRangeEnd = 231568, XrefRangeStart = 231565, XrefRangeEnd = 231567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x060076A1 RID: 30369 RVA: 0x00206F98 File Offset: 0x00205198
		public unsafe float NormalizedTrashLevel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 231569, RefRangeEnd = 231573, XrefRangeStart = 231568, XrefRangeEnd = 231569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00206FD4 File Offset: 0x002051D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231573, XrefRangeEnd = 231613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00207024 File Offset: 0x00205224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231613, XrefRangeEnd = 231626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00207074 File Offset: 0x00205274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231626, XrefRangeEnd = 231649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x002070C4 File Offset: 0x002052C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 231695, RefRangeEnd = 231699, XrefRangeStart = 231649, XrefRangeEnd = 231695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00207128 File Offset: 0x00205328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231699, XrefRangeEnd = 231720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x0020715C File Offset: 0x0020535C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231741, RefRangeEnd = 231744, XrefRangeStart = 231720, XrefRangeEnd = 231741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00207190 File Offset: 0x00205390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231744, XrefRangeEnd = 231754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x002071E4 File Offset: 0x002053E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231754, XrefRangeEnd = 231763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00207228 File Offset: 0x00205428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231763, XrefRangeEnd = 231764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeBagged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00207264 File Offset: 0x00205464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231813, RefRangeEnd = 231814, XrefRangeStart = 231764, XrefRangeEnd = 231813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BagTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00207298 File Offset: 0x00205498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231814, XrefRangeEnd = 231820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x002072D4 File Offset: 0x002054D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231820, XrefRangeEnd = 231858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00207310 File Offset: 0x00205510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213394, RefRangeEnd = 213395, XrefRangeStart = 213394, XrefRangeEnd = 213395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x0020734C File Offset: 0x0020554C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00207388 File Offset: 0x00205588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231858, XrefRangeEnd = 231870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x002073D8 File Offset: 0x002055D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231870, XrefRangeEnd = 231871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00207428 File Offset: 0x00205628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231871, XrefRangeEnd = 231877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x0020748C File Offset: 0x0020568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231877, XrefRangeEnd = 231889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x002074F0 File Offset: 0x002056F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231894, RefRangeEnd = 231897, XrefRangeStart = 231889, XrefRangeEnd = 231894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00207554 File Offset: 0x00205754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231897, XrefRangeEnd = 231903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x002075A4 File Offset: 0x002057A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231903, XrefRangeEnd = 231915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00207608 File Offset: 0x00205808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231915, XrefRangeEnd = 231921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00207658 File Offset: 0x00205858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231921, XrefRangeEnd = 231930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x0020768C File Offset: 0x0020588C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231741, RefRangeEnd = 231744, XrefRangeStart = 231741, XrefRangeEnd = 231744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x002076C0 File Offset: 0x002058C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231930, XrefRangeEnd = 231933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00207724 File Offset: 0x00205924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231933, XrefRangeEnd = 231942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00207758 File Offset: 0x00205958
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231945, RefRangeEnd = 231948, XrefRangeStart = 231942, XrefRangeEnd = 231945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x0020778C File Offset: 0x0020598C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231948, XrefRangeEnd = 231951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x002077DC File Offset: 0x002059DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00207830 File Offset: 0x00205A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231951, XrefRangeEnd = 231953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00207884 File Offset: 0x00205A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231953, XrefRangeEnd = 231958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x002078D4 File Offset: 0x00205AD4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x0003815A File Offset: 0x0003635A
		public TrashContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x060076C3 RID: 30403 RVA: 0x00207910 File Offset: 0x00205B10
		// (set) Token: 0x060076C4 RID: 30404 RVA: 0x00038163 File Offset: 0x00036363
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x060076C5 RID: 30405 RVA: 0x00207940 File Offset: 0x00205B40
		// (set) Token: 0x060076C6 RID: 30406 RVA: 0x00038182 File Offset: 0x00036382
		public unsafe int TrashCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity)) = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x00207968 File Offset: 0x00205B68
		// (set) Token: 0x060076C8 RID: 30408 RVA: 0x0003819D File Offset: 0x0003639D
		public unsafe Transform TrashBagDropLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x00207998 File Offset: 0x00205B98
		// (set) Token: 0x060076CA RID: 30410 RVA: 0x000381BC File Offset: 0x000363BC
		public unsafe UnityEvent<string> onTrashAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x060076CB RID: 30411 RVA: 0x002079C8 File Offset: 0x00205BC8
		// (set) Token: 0x060076CC RID: 30412 RVA: 0x000381DB File Offset: 0x000363DB
		public unsafe UnityEvent onTrashLevelChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x002079F8 File Offset: 0x00205BF8
		// (set) Token: 0x060076CE RID: 30414 RVA: 0x000381FA File Offset: 0x000363FA
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x060076CF RID: 30415 RVA: 0x00207A20 File Offset: 0x00205C20
		// (set) Token: 0x060076D0 RID: 30416 RVA: 0x00038215 File Offset: 0x00036415
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040050FE RID: 20734
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040050FF RID: 20735
		private static readonly IntPtr NativeFieldInfoPtr_TrashCapacity;

		// Token: 0x04005100 RID: 20736
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagDropLocation;

		// Token: 0x04005101 RID: 20737
		private static readonly IntPtr NativeFieldInfoPtr_onTrashAdded;

		// Token: 0x04005102 RID: 20738
		private static readonly IntPtr NativeFieldInfoPtr_onTrashLevelChanged;

		// Token: 0x04005103 RID: 20739
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005104 RID: 20740
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005105 RID: 20741
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x04005106 RID: 20742
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0;

		// Token: 0x04005107 RID: 20743
		private static readonly IntPtr NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0;

		// Token: 0x04005108 RID: 20744
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0;

		// Token: 0x04005109 RID: 20745
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0;

		// Token: 0x0400510A RID: 20746
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400510B RID: 20747
		private static readonly IntPtr NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0;

		// Token: 0x0400510C RID: 20748
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400510D RID: 20749
		private static readonly IntPtr NativeMethodInfoPtr_SendClear_Private_Void_0;

		// Token: 0x0400510E RID: 20750
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x0400510F RID: 20751
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04005110 RID: 20752
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0;

		// Token: 0x04005111 RID: 20753
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0;

		// Token: 0x04005112 RID: 20754
		private static readonly IntPtr NativeMethodInfoPtr_BagTrash_Public_Void_0;

		// Token: 0x04005113 RID: 20755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005114 RID: 20756
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005115 RID: 20757
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005116 RID: 20758
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005117 RID: 20759
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04005118 RID: 20760
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04005119 RID: 20761
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400511A RID: 20762
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400511B RID: 20763
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400511C RID: 20764
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400511D RID: 20765
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400511E RID: 20766
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400511F RID: 20767
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0;

		// Token: 0x04005120 RID: 20768
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0;

		// Token: 0x04005121 RID: 20769
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005122 RID: 20770
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0;

		// Token: 0x04005123 RID: 20771
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0;

		// Token: 0x04005124 RID: 20772
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005125 RID: 20773
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04005126 RID: 20774
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04005127 RID: 20775
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005128 RID: 20776
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
