using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200059D RID: 1437
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x06007D8F RID: 32143 RVA: 0x0021EBA4 File Offset: 0x0021CDA4
		// Note: this type is marked as 'beforefieldinit'.
		static StorageTile()
		{
			Il2CppClassPointerStore<StorageTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageTile>.NativeClassPtr);
			StorageTile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "x");
			StorageTile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "y");
			StorageTile.NativeFieldInfoPtr_ownerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "ownerGrid");
			StorageTile.NativeFieldInfoPtr_onOccupantChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "onOccupantChanged");
			StorageTile.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "<occupant>k__BackingField");
			StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679141);
			StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679142);
			StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679143);
			StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679144);
			StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679145);
			StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100679146);
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06007D90 RID: 32144 RVA: 0x0021ECB0 File Offset: 0x0021CEB0
		public unsafe StorageGrid _ownerGrid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x0021ECF0 File Offset: 0x0021CEF0
		// (set) Token: 0x06007D92 RID: 32146 RVA: 0x0021ED30 File Offset: 0x0021CF30
		public unsafe StoredItem occupant
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x0021ED74 File Offset: 0x0021CF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240134, XrefRangeEnd = 240135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _y;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x0021EDE4 File Offset: 0x0021CFE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240149, RefRangeEnd = 240152, XrefRangeStart = 240135, XrefRangeEnd = 240149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(StoredItem occ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D95 RID: 32149 RVA: 0x0021EE28 File Offset: 0x0021D028
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageTile>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x0003B4F5 File Offset: 0x000396F5
		public StorageTile(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0021EE64 File Offset: 0x0021D064
		// (set) Token: 0x06007D98 RID: 32152 RVA: 0x0003B4FE File Offset: 0x000396FE
		public unsafe int x
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06007D99 RID: 32153 RVA: 0x0021EE8C File Offset: 0x0021D08C
		// (set) Token: 0x06007D9A RID: 32154 RVA: 0x0003B519 File Offset: 0x00039719
		public unsafe int y
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0021EEB4 File Offset: 0x0021D0B4
		// (set) Token: 0x06007D9C RID: 32156 RVA: 0x0003B534 File Offset: 0x00039734
		public unsafe StorageGrid ownerGrid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0021EEE4 File Offset: 0x0021D0E4
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0003B553 File Offset: 0x00039753
		public unsafe Il2CppSystem.Action onOccupantChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0021EF14 File Offset: 0x0021D114
		// (set) Token: 0x06007DA0 RID: 32160 RVA: 0x0003B572 File Offset: 0x00039772
		public unsafe StoredItem _occupant_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005589 RID: 21897
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400558A RID: 21898
		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400558B RID: 21899
		private static readonly System.IntPtr NativeFieldInfoPtr_ownerGrid;

		// Token: 0x0400558C RID: 21900
		private static readonly System.IntPtr NativeFieldInfoPtr_onOccupantChanged;

		// Token: 0x0400558D RID: 21901
		private static readonly System.IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x0400558E RID: 21902
		private static readonly System.IntPtr NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0;

		// Token: 0x0400558F RID: 21903
		private static readonly System.IntPtr NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0;

		// Token: 0x04005590 RID: 21904
		private static readonly System.IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0;

		// Token: 0x04005591 RID: 21905
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0;

		// Token: 0x04005592 RID: 21906
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0;

		// Token: 0x04005593 RID: 21907
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
