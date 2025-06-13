using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F2 RID: 1522
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x06008531 RID: 34097 RVA: 0x00238E14 File Offset: 0x00237014
		// Note: this type is marked as 'beforefieldinit'.
		static AdditiveDefinition()
		{
			Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "AdditiveDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr);
			AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "AdditivePrefab");
			AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100680060);
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00238E6C File Offset: 0x0023706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditiveDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x0003F0C7 File Offset: 0x0003D2C7
		public AdditiveDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x06008534 RID: 34100 RVA: 0x00238EA8 File Offset: 0x002370A8
		// (set) Token: 0x06008535 RID: 34101 RVA: 0x0003F0D0 File Offset: 0x0003D2D0
		public unsafe Additive AdditivePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AAA RID: 23210
		private static readonly IntPtr NativeFieldInfoPtr_AdditivePrefab;

		// Token: 0x04005AAB RID: 23211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
