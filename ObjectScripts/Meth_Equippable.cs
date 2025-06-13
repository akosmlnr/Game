using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000763 RID: 1891
	public class Meth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600ACB7 RID: 44215 RVA: 0x002B3840 File Offset: 0x002B1A40
		// Note: this type is marked as 'beforefieldinit'.
		static Meth_Equippable()
		{
			Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Meth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr);
			Meth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, "Visuals");
			Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100684567);
			Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100684568);
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x002B38AC File Offset: 0x002B1AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299532, XrefRangeEnd = 299541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x002B38FC File Offset: 0x002B1AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Meth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x00054D37 File Offset: 0x00052F37
		public Meth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600ACBB RID: 44219 RVA: 0x002B3938 File Offset: 0x002B1B38
		// (set) Token: 0x0600ACBC RID: 44220 RVA: 0x00054D40 File Offset: 0x00052F40
		public unsafe MethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073F7 RID: 29687
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040073F8 RID: 29688
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040073F9 RID: 29689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
