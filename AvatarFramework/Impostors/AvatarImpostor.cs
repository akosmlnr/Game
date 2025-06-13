using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000620 RID: 1568
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x06008949 RID: 35145 RVA: 0x00246620 File Offset: 0x00244820
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImpostor()
		{
			Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "AvatarImpostor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr);
			AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "<HasTexture>k__BackingField");
			AvatarImpostor.NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "meshRenderer");
			AvatarImpostor.NativeFieldInfoPtr_cachedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "cachedCamera");
			AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680535);
			AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680536);
			AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680537);
			AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680538);
			AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680539);
			AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680540);
			AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680541);
			AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680542);
			AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680543);
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x00246740 File Offset: 0x00244940
		// (set) Token: 0x0600894B RID: 35147 RVA: 0x0024677C File Offset: 0x0024497C
		public unsafe bool HasTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x002467BC File Offset: 0x002449BC
		public unsafe Transform Camera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 255203, RefRangeEnd = 255205, XrefRangeStart = 255192, XrefRangeEnd = 255203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x002467FC File Offset: 0x002449FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255205, XrefRangeEnd = 255211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x00246840 File Offset: 0x00244A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255211, XrefRangeEnd = 255212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x00246874 File Offset: 0x00244A74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255226, RefRangeEnd = 255229, XrefRangeStart = 255212, XrefRangeEnd = 255226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Realign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x002468A8 File Offset: 0x00244AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255229, XrefRangeEnd = 255233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x002468DC File Offset: 0x00244ADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199161, XrefRangeEnd = 199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x00246910 File Offset: 0x00244B10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarImpostor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x000410EB File Offset: 0x0003F2EB
		public AvatarImpostor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x06008954 RID: 35156 RVA: 0x0024694C File Offset: 0x00244B4C
		// (set) Token: 0x06008955 RID: 35157 RVA: 0x000410F4 File Offset: 0x0003F2F4
		public unsafe bool _HasTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x06008956 RID: 35158 RVA: 0x00246974 File Offset: 0x00244B74
		// (set) Token: 0x06008957 RID: 35159 RVA: 0x0004110F File Offset: 0x0003F30F
		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x06008958 RID: 35160 RVA: 0x002469A4 File Offset: 0x00244BA4
		// (set) Token: 0x06008959 RID: 35161 RVA: 0x0004112E File Offset: 0x0003F32E
		public unsafe Transform cachedCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D71 RID: 23921
		private static readonly IntPtr NativeFieldInfoPtr__HasTexture_k__BackingField;

		// Token: 0x04005D72 RID: 23922
		private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

		// Token: 0x04005D73 RID: 23923
		private static readonly IntPtr NativeFieldInfoPtr_cachedCamera;

		// Token: 0x04005D74 RID: 23924
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0;

		// Token: 0x04005D75 RID: 23925
		private static readonly IntPtr NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0;

		// Token: 0x04005D76 RID: 23926
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Private_get_Transform_0;

		// Token: 0x04005D77 RID: 23927
		private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005D78 RID: 23928
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005D79 RID: 23929
		private static readonly IntPtr NativeMethodInfoPtr_Realign_Private_Void_0;

		// Token: 0x04005D7A RID: 23930
		private static readonly IntPtr NativeMethodInfoPtr_EnableImpostor_Public_Void_0;

		// Token: 0x04005D7B RID: 23931
		private static readonly IntPtr NativeMethodInfoPtr_DisableImpostor_Public_Void_0;

		// Token: 0x04005D7C RID: 23932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
