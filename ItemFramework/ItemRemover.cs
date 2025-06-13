using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060B RID: 1547
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x06008627 RID: 34343 RVA: 0x0023C07C File Offset: 0x0023A27C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemRemover()
		{
			Il2CppClassPointerStore<ItemRemover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemRemover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr);
			ItemRemover.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Item");
			ItemRemover.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Quantity");
			ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100680167);
			ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100680168);
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x0023C0FC File Offset: 0x0023A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251566, XrefRangeEnd = 251572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x0023C130 File Offset: 0x0023A330
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemRemover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x0003F715 File Offset: 0x0003D915
		public ItemRemover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600862B RID: 34347 RVA: 0x0023C16C File Offset: 0x0023A36C
		// (set) Token: 0x0600862C RID: 34348 RVA: 0x0003F71E File Offset: 0x0003D91E
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x0023C19C File Offset: 0x0023A39C
		// (set) Token: 0x0600862E RID: 34350 RVA: 0x0003F73D File Offset: 0x0003D93D
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04005B58 RID: 23384
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04005B59 RID: 23385
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005B5A RID: 23386
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x04005B5B RID: 23387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
