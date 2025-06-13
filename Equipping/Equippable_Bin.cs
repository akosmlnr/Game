using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.HandheldBin;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DC RID: 1500
	public class Equippable_Bin : Equippable_Viewmodel
	{
		// Token: 0x060082B0 RID: 33456 RVA: 0x00230E3C File Offset: 0x0022F03C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Bin()
		{
			Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr);
			Equippable_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, "bin");
			Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, 100679794);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x00230E94 File Offset: 0x0022F094
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 248176, RefRangeEnd = 248183, XrefRangeStart = 248176, XrefRangeEnd = 248183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0003DBF5 File Offset: 0x0003BDF5
		public Equippable_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x060082B3 RID: 33459 RVA: 0x00230ED0 File Offset: 0x0022F0D0
		// (set) Token: 0x060082B4 RID: 33460 RVA: 0x0003DBFE File Offset: 0x0003BDFE
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005909 RID: 22793
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x0400590A RID: 22794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
