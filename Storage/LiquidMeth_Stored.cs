using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200058E RID: 1422
	public class LiquidMeth_Stored : StoredItem
	{
		// Token: 0x06007C0F RID: 31759 RVA: 0x002182F8 File Offset: 0x002164F8
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Stored()
		{
			Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "LiquidMeth_Stored");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr);
			LiquidMeth_Stored.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, "Visuals");
			LiquidMeth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, 100678908);
			LiquidMeth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, 100678909);
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x00218364 File Offset: 0x00216564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237331, XrefRangeEnd = 237340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x002183E0 File Offset: 0x002165E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Stored() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x0003AD51 File Offset: 0x00038F51
		public LiquidMeth_Stored(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x0021841C File Offset: 0x0021661C
		// (set) Token: 0x06007C14 RID: 31764 RVA: 0x0003AD5A File Offset: 0x00038F5A
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Stored.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Stored.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005468 RID: 21608
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005469 RID: 21609
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400546A RID: 21610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
