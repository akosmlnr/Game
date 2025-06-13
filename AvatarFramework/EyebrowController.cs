using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061B RID: 1563
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x060088C7 RID: 35015 RVA: 0x00244E94 File Offset: 0x00243094
		// Note: this type is marked as 'beforefieldinit'.
		static EyebrowController()
		{
			Il2CppClassPointerStore<EyebrowController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyebrowController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr);
			EyebrowController.NativeFieldInfoPtr_leftBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "leftBrow");
			EyebrowController.NativeFieldInfoPtr_rightBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "rightBrow");
			EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680477);
			EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680478);
			EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680479);
			EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680480);
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x00244F3C File Offset: 0x0024313C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254887, RefRangeEnd = 254891, XrefRangeStart = 254875, XrefRangeEnd = 254887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x00244F80 File Offset: 0x00243180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254891, XrefRangeEnd = 254893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x00244FC0 File Offset: 0x002431C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254893, XrefRangeEnd = 254895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088CB RID: 35019 RVA: 0x00245000 File Offset: 0x00243200
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyebrowController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x00040C39 File Offset: 0x0003EE39
		public EyebrowController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x0024503C File Offset: 0x0024323C
		// (set) Token: 0x060088CE RID: 35022 RVA: 0x00040C42 File Offset: 0x0003EE42
		public unsafe Eyebrow leftBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x0024506C File Offset: 0x0024326C
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x00040C61 File Offset: 0x0003EE61
		public unsafe Eyebrow rightBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D20 RID: 23840
		private static readonly IntPtr NativeFieldInfoPtr_leftBrow;

		// Token: 0x04005D21 RID: 23841
		private static readonly IntPtr NativeFieldInfoPtr_rightBrow;

		// Token: 0x04005D22 RID: 23842
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005D23 RID: 23843
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005D24 RID: 23844
		private static readonly IntPtr NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005D25 RID: 23845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
