using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200040C RID: 1036
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x060053D1 RID: 21457 RVA: 0x0018E768 File Offset: 0x0018C968
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelAvatar()
		{
			Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelAvatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr);
			ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "<IsVisible>k__BackingField");
			ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "ParentAvatar");
			ViewmodelAvatar.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Animator");
			ViewmodelAvatar.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Avatar");
			ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "RightHandContainer");
			ViewmodelAvatar.NativeFieldInfoPtr_baseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "baseOffset");
			ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673890);
			ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673891);
			ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673892);
			ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673893);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673894);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673895);
			ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673896);
			ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673897);
			ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673898);
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060053D2 RID: 21458 RVA: 0x0018E8C4 File Offset: 0x0018CAC4
		// (set) Token: 0x060053D3 RID: 21459 RVA: 0x0018E900 File Offset: 0x0018CB00
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x0018E940 File Offset: 0x0018CB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182037, XrefRangeEnd = 182061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0018E97C File Offset: 0x0018CB7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182068, RefRangeEnd = 182073, XrefRangeStart = 182061, XrefRangeEnd = 182068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isVisible;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0018E9BC File Offset: 0x0018CBBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182101, RefRangeEnd = 182103, XrefRangeStart = 182073, XrefRangeEnd = 182101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x0018EA00 File Offset: 0x0018CC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182105, RefRangeEnd = 182107, XrefRangeStart = 182103, XrefRangeEnd = 182105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimatorController(RuntimeAnimatorController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x0018EA44 File Offset: 0x0018CC44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182109, RefRangeEnd = 182111, XrefRangeStart = 182107, XrefRangeEnd = 182109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0018EA84 File Offset: 0x0018CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182111, XrefRangeEnd = 182114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelAvatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0018EAC0 File Offset: 0x0018CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182114, XrefRangeEnd = 182116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00027AF2 File Offset: 0x00025CF2
		public ViewmodelAvatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x0018EAF4 File Offset: 0x0018CCF4
		// (set) Token: 0x060053DD RID: 21469 RVA: 0x00027AFB File Offset: 0x00025CFB
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0018EB1C File Offset: 0x0018CD1C
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x00027B16 File Offset: 0x00025D16
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0018EB4C File Offset: 0x0018CD4C
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x00027B35 File Offset: 0x00025D35
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0018EB7C File Offset: 0x0018CD7C
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x00027B54 File Offset: 0x00025D54
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0018EBAC File Offset: 0x0018CDAC
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x00027B73 File Offset: 0x00025D73
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0018EBDC File Offset: 0x0018CDDC
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x00027B92 File Offset: 0x00025D92
		public unsafe Vector3 baseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset)) = value;
			}
		}

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeFieldInfoPtr_baseOffset;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0;
	}
}
