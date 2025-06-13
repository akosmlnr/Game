using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000634 RID: 1588
	public class PoliceBelt : Accessory
	{
		// Token: 0x06008B89 RID: 35721 RVA: 0x0024CB44 File Offset: 0x0024AD44
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceBelt()
		{
			Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "PoliceBelt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr);
			PoliceBelt.NativeFieldInfoPtr_BatonObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "BatonObject");
			PoliceBelt.NativeFieldInfoPtr_TaserObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "TaserObject");
			PoliceBelt.NativeFieldInfoPtr_GunObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "GunObject");
			PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680763);
			PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680764);
			PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680765);
			PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680766);
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x0024CC00 File Offset: 0x0024AE00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257250, RefRangeEnd = 257253, XrefRangeStart = 257247, XrefRangeEnd = 257250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBatonVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x0024CC40 File Offset: 0x0024AE40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257256, RefRangeEnd = 257259, XrefRangeStart = 257253, XrefRangeEnd = 257256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTaserVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x0024CC80 File Offset: 0x0024AE80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257262, RefRangeEnd = 257265, XrefRangeStart = 257259, XrefRangeEnd = 257262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGunVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x0024CCC0 File Offset: 0x0024AEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257265, XrefRangeEnd = 257266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceBelt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x000425EF File Offset: 0x000407EF
		public PoliceBelt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x0024CCFC File Offset: 0x0024AEFC
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x000425F8 File Offset: 0x000407F8
		public unsafe GameObject BatonObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x0024CD2C File Offset: 0x0024AF2C
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x00042617 File Offset: 0x00040817
		public unsafe GameObject TaserObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x06008B93 RID: 35731 RVA: 0x0024CD5C File Offset: 0x0024AF5C
		// (set) Token: 0x06008B94 RID: 35732 RVA: 0x00042636 File Offset: 0x00040836
		public unsafe GameObject GunObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ECA RID: 24266
		private static readonly IntPtr NativeFieldInfoPtr_BatonObject;

		// Token: 0x04005ECB RID: 24267
		private static readonly IntPtr NativeFieldInfoPtr_TaserObject;

		// Token: 0x04005ECC RID: 24268
		private static readonly IntPtr NativeFieldInfoPtr_GunObject;

		// Token: 0x04005ECD RID: 24269
		private static readonly IntPtr NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0;

		// Token: 0x04005ECE RID: 24270
		private static readonly IntPtr NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0;

		// Token: 0x04005ECF RID: 24271
		private static readonly IntPtr NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0;

		// Token: 0x04005ED0 RID: 24272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
