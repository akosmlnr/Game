using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DA RID: 1498
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060082A3 RID: 33443 RVA: 0x00230B9C File Offset: 0x0022ED9C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Equippable()
		{
			Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "LiquidMeth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr);
			LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, "Visuals");
			LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679789);
			LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679790);
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x00230C08 File Offset: 0x0022EE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248164, XrefRangeEnd = 248173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x00230C58 File Offset: 0x0022EE58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 248176, RefRangeEnd = 248183, XrefRangeStart = 248173, XrefRangeEnd = 248176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0003DBA5 File Offset: 0x0003BDA5
		public LiquidMeth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x060082A7 RID: 33447 RVA: 0x00230C94 File Offset: 0x0022EE94
		// (set) Token: 0x060082A8 RID: 33448 RVA: 0x0003DBAE File Offset: 0x0003BDAE
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005902 RID: 22786
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005903 RID: 22787
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005904 RID: 22788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
