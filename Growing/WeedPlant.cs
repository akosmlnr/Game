using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000582 RID: 1410
	public class WeedPlant : Plant
	{
		// Token: 0x06007AE5 RID: 31461 RVA: 0x00214D14 File Offset: 0x00212F14
		// Note: this type is marked as 'beforefieldinit'.
		static WeedPlant()
		{
			Il2CppClassPointerStore<WeedPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "WeedPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr);
			WeedPlant.NativeFieldInfoPtr_BranchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, "BranchPrefab");
			WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678802);
			WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678803);
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x00214D80 File Offset: 0x00212F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236442, XrefRangeEnd = 236448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00214DD8 File Offset: 0x00212FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x0003A179 File Offset: 0x00038379
		public WeedPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06007AE9 RID: 31465 RVA: 0x00214E14 File Offset: 0x00213014
		// (set) Token: 0x06007AEA RID: 31466 RVA: 0x0003A182 File Offset: 0x00038382
		public unsafe PlantHarvestable BranchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053B6 RID: 21430
		private static readonly IntPtr NativeFieldInfoPtr_BranchPrefab;

		// Token: 0x040053B7 RID: 21431
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040053B8 RID: 21432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
