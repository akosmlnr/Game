using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000590 RID: 1424
	public class IStorageEntity : Il2CppObjectBase
	{
		// Token: 0x06007C20 RID: 31776 RVA: 0x00218684 File Offset: 0x00216884
		// Note: this type is marked as 'beforefieldinit'.
		static IStorageEntity()
		{
			Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "IStorageEntity");
			IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678915);
			IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678916);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678917);
			IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678918);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678919);
			IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678920);
			IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678921);
			IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678922);
			IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678923);
			IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678924);
			IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678925);
			IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678926);
			IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678927);
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06007C21 RID: 31777 RVA: 0x002187B0 File Offset: 0x002169B0
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x002187FC File Offset: 0x002169FC
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x00218848 File Offset: 0x00216A48
		[CallerCount(0)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x00218894 File Offset: 0x00216A94
		[CallerCount(0)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr2) : null;
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x002188E0 File Offset: 0x00216AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237355, XrefRangeEnd = 237376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItemsByID(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0021893C File Offset: 0x00216B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237376, XrefRangeEnd = 237393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReserveItem(StoredItem item, Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employee);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x0021899C File Offset: 0x00216B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237393, XrefRangeEnd = 237404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DereserveItem(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x002189EC File Offset: 0x00216BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237404, XrefRangeEnd = 237411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsItemReserved(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x00218A44 File Offset: 0x00216C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237411, XrefRangeEnd = 237418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Employee WhoIsReserving(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x00218AA0 File Offset: 0x00216CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237418, XrefRangeEnd = 237448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(whosAskin);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x00218B10 File Offset: 0x00216D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237448, XrefRangeEnd = 237454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ClearReserve(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x00218B6C File Offset: 0x00216D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237454, XrefRangeEnd = 237478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sizeY;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &rotation;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			grid = ((intPtr3 == 0) ? null : new StorageGrid(intPtr3));
			System.IntPtr intPtr4 = intPtr2;
			originCoordinate = ((intPtr4 == 0) ? null : new Coordinate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x00218C24 File Offset: 0x00216E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237478, XrefRangeEnd = 237503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sizeY;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref limit;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x0003ADB8 File Offset: 0x00038FB8
		public IStorageEntity(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005472 RID: 21618
		private static readonly System.IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x04005473 RID: 21619
		private static readonly System.IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005474 RID: 21620
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0;

		// Token: 0x04005475 RID: 21621
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0;

		// Token: 0x04005476 RID: 21622
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0;

		// Token: 0x04005477 RID: 21623
		private static readonly System.IntPtr NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0;

		// Token: 0x04005478 RID: 21624
		private static readonly System.IntPtr NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0;

		// Token: 0x04005479 RID: 21625
		private static readonly System.IntPtr NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0;

		// Token: 0x0400547A RID: 21626
		private static readonly System.IntPtr NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0;

		// Token: 0x0400547B RID: 21627
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0;

		// Token: 0x0400547C RID: 21628
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0;

		// Token: 0x0400547D RID: 21629
		private static readonly System.IntPtr NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0;

		// Token: 0x0400547E RID: 21630
		private static readonly System.IntPtr NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x02000AFE RID: 2814
		[ObfuscatedName("ScheduleOne.Storage.IStorageEntity+<ClearReserve>d__12")]
		public sealed class _ClearReserve_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D8BB RID: 55483 RVA: 0x0033E650 File Offset: 0x0033C850
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearReserve_d__12()
			{
				Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, "<ClearReserve>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr);
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>1__state");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>2__current");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "item");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>4__this");
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678928);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678929);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678930);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678931);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678932);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678933);
			}

			// Token: 0x0600D8BC RID: 55484 RVA: 0x0033E744 File Offset: 0x0033C944
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearReserve_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8BD RID: 55485 RVA: 0x0033E78C File Offset: 0x0033C98C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8BE RID: 55486 RVA: 0x0033E7C0 File Offset: 0x0033C9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237343, XrefRangeEnd = 237350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170042EB RID: 17131
			// (get) Token: 0x0600D8BF RID: 55487 RVA: 0x0033E7FC File Offset: 0x0033C9FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D8C0 RID: 55488 RVA: 0x0033E83C File Offset: 0x0033CA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237350, XrefRangeEnd = 237355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170042EC RID: 17132
			// (get) Token: 0x0600D8C1 RID: 55489 RVA: 0x0033E870 File Offset: 0x0033CA70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D8C2 RID: 55490 RVA: 0x00069321 File Offset: 0x00067521
			public _ClearReserve_d__12(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E7 RID: 17127
			// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x0033E8B0 File Offset: 0x0033CAB0
			// (set) Token: 0x0600D8C4 RID: 55492 RVA: 0x0006932A File Offset: 0x0006752A
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042E8 RID: 17128
			// (get) Token: 0x0600D8C5 RID: 55493 RVA: 0x0033E8D8 File Offset: 0x0033CAD8
			// (set) Token: 0x0600D8C6 RID: 55494 RVA: 0x00069345 File Offset: 0x00067545
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E9 RID: 17129
			// (get) Token: 0x0600D8C7 RID: 55495 RVA: 0x0033E908 File Offset: 0x0033CB08
			// (set) Token: 0x0600D8C8 RID: 55496 RVA: 0x00069364 File Offset: 0x00067564
			public unsafe StoredItem item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EA RID: 17130
			// (get) Token: 0x0600D8C9 RID: 55497 RVA: 0x0033E938 File Offset: 0x0033CB38
			// (set) Token: 0x0600D8CA RID: 55498 RVA: 0x00069383 File Offset: 0x00067583
			public unsafe IStorageEntity __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009208 RID: 37384
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009209 RID: 37385
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400920A RID: 37386
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400920B RID: 37387
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400920C RID: 37388
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400920D RID: 37389
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400920E RID: 37390
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400920F RID: 37391
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009210 RID: 37392
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009211 RID: 37393
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
