using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057B RID: 1403
	public class CocaPlant : Plant
	{
		// Token: 0x06007A6E RID: 31342 RVA: 0x002136E0 File Offset: 0x002118E0
		// Note: this type is marked as 'beforefieldinit'.
		static CocaPlant()
		{
			Il2CppClassPointerStore<CocaPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "CocaPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr);
			CocaPlant.NativeFieldInfoPtr_Harvestable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, "Harvestable");
			CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678761);
			CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678762);
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0021374C File Offset: 0x0021194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236125, XrefRangeEnd = 236131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x002137A4 File Offset: 0x002119A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236131, XrefRangeEnd = 236132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x00039D46 File Offset: 0x00037F46
		public CocaPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x002137E0 File Offset: 0x002119E0
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x00039D4F File Offset: 0x00037F4F
		public unsafe PlantHarvestable Harvestable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005370 RID: 21360
		private static readonly IntPtr NativeFieldInfoPtr_Harvestable;

		// Token: 0x04005371 RID: 21361
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005372 RID: 21362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
