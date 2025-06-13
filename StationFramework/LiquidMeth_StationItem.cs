using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005A6 RID: 1446
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x06007E69 RID: 32361 RVA: 0x002219A0 File Offset: 0x0021FBA0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_StationItem()
		{
			Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidMeth_StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr);
			LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, "Visuals");
			LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100679243);
			LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100679244);
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x00221A0C File Offset: 0x0021FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241084, XrefRangeEnd = 241102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x00221A5C File Offset: 0x0021FC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241102, XrefRangeEnd = 241103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x0003BB6B File Offset: 0x00039D6B
		public LiquidMeth_StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x00221A98 File Offset: 0x0021FC98
		// (set) Token: 0x06007E6E RID: 32366 RVA: 0x0003BB74 File Offset: 0x00039D74
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400561C RID: 22044
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400561D RID: 22045
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x0400561E RID: 22046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
