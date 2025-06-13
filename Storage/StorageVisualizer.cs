using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200059F RID: 1439
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x06007DA4 RID: 32164 RVA: 0x0021EF98 File Offset: 0x0021D198
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizer()
		{
			Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr);
			StorageVisualizer.NativeFieldInfoPtr_StorageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "StorageGrids");
			StorageVisualizer.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "ItemContainer");
			StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "FullRefreshOnItemRemoved");
			StorageVisualizer.NativeFieldInfoPtr_itemSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "itemSlots");
			StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "totalFootprintCapacity");
			StorageVisualizer.NativeFieldInfoPtr_activeStoredItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "activeStoredItems");
			StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "BlockRefreshes");
			StorageVisualizer.NativeFieldInfoPtr_updateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "updateVisuals");
			StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679148);
			StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679149);
			StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679150);
			StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679151);
			StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679152);
			StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679153);
			StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679154);
			StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679155);
			StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679156);
			StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679157);
			StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100679158);
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x0021F144 File Offset: 0x0021D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240218, XrefRangeEnd = 240222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x0021F180 File Offset: 0x0021D380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240222, XrefRangeEnd = 240229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x0021F1BC File Offset: 0x0021D3BC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 240248, RefRangeEnd = 240265, XrefRangeStart = 240229, XrefRangeEnd = 240248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot, bool update = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref update;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x0021F20C File Offset: 0x0021D40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240265, XrefRangeEnd = 240267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr2) : null;
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x0021F24C File Offset: 0x0021D44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240267, XrefRangeEnd = 240417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x0021F288 File Offset: 0x0021D488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240469, RefRangeEnd = 240470, XrefRangeStart = 240417, XrefRangeEnd = 240469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x0021F2E8 File Offset: 0x0021D4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240492, RefRangeEnd = 240493, XrefRangeStart = 240470, XrefRangeEnd = 240492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x0021F338 File Offset: 0x0021D538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240530, RefRangeEnd = 240532, XrefRangeStart = 240493, XrefRangeEnd = 240530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr2) : null;
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x0021F378 File Offset: 0x0021D578
		[CallerCount(0)]
		public unsafe void QueueRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x0021F3AC File Offset: 0x0021D5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x0021F3E8 File Offset: 0x0021D5E8
		[CallerCount(0)]
		public unsafe void _AddSlot_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x0003B5D3 File Offset: 0x000397D3
		public StorageVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x0021F41C File Offset: 0x0021D61C
		// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x0003B5DC File Offset: 0x000397DC
		public unsafe Il2CppReferenceArray<StorageGrid> StorageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x0021F44C File Offset: 0x0021D64C
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x0003B5FB File Offset: 0x000397FB
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x0021F47C File Offset: 0x0021D67C
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x0003B61A File Offset: 0x0003981A
		public unsafe bool FullRefreshOnItemRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved)) = value;
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x0021F4A4 File Offset: 0x0021D6A4
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x0003B635 File Offset: 0x00039835
		public unsafe List<ItemSlot> itemSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x0021F4D4 File Offset: 0x0021D6D4
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x0003B654 File Offset: 0x00039854
		public unsafe int totalFootprintCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity)) = value;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x0021F4FC File Offset: 0x0021D6FC
		// (set) Token: 0x06007DBC RID: 32188 RVA: 0x0003B66F File Offset: 0x0003986F
		public unsafe Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, List<StoredItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06007DBD RID: 32189 RVA: 0x0021F52C File Offset: 0x0021D72C
		// (set) Token: 0x06007DBE RID: 32190 RVA: 0x0003B68E File Offset: 0x0003988E
		public unsafe bool BlockRefreshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes)) = value;
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x0021F554 File Offset: 0x0021D754
		// (set) Token: 0x06007DC0 RID: 32192 RVA: 0x0003B6A9 File Offset: 0x000398A9
		public unsafe bool updateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals)) = value;
			}
		}

		// Token: 0x04005595 RID: 21909
		private static readonly IntPtr NativeFieldInfoPtr_StorageGrids;

		// Token: 0x04005596 RID: 21910
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005597 RID: 21911
		private static readonly IntPtr NativeFieldInfoPtr_FullRefreshOnItemRemoved;

		// Token: 0x04005598 RID: 21912
		private static readonly IntPtr NativeFieldInfoPtr_itemSlots;

		// Token: 0x04005599 RID: 21913
		private static readonly IntPtr NativeFieldInfoPtr_totalFootprintCapacity;

		// Token: 0x0400559A RID: 21914
		private static readonly IntPtr NativeFieldInfoPtr_activeStoredItems;

		// Token: 0x0400559B RID: 21915
		private static readonly IntPtr NativeFieldInfoPtr_BlockRefreshes;

		// Token: 0x0400559C RID: 21916
		private static readonly IntPtr NativeFieldInfoPtr_updateVisuals;

		// Token: 0x0400559D RID: 21917
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400559E RID: 21918
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400559F RID: 21919
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0;

		// Token: 0x040055A0 RID: 21920
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x040055A1 RID: 21921
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0;

		// Token: 0x040055A2 RID: 21922
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0;

		// Token: 0x040055A3 RID: 21923
		private static readonly IntPtr NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0;

		// Token: 0x040055A4 RID: 21924
		private static readonly IntPtr NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x040055A5 RID: 21925
		private static readonly IntPtr NativeMethodInfoPtr_QueueRefresh_Protected_Void_0;

		// Token: 0x040055A6 RID: 21926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040055A7 RID: 21927
		private static readonly IntPtr NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0;
	}
}
