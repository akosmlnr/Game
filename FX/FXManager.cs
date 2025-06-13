using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000418 RID: 1048
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x06005610 RID: 22032 RVA: 0x00194DC8 File Offset: 0x00192FC8
		// Note: this type is marked as 'beforefieldinit'.
		static FXManager()
		{
			Il2CppClassPointerStore<FXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "FXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager>.NativeClassPtr);
			FXManager.NativeFieldInfoPtr_PunchImpactsClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchImpactsClips");
			FXManager.NativeFieldInfoPtr_SlashImpactClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "SlashImpactClips");
			FXManager.NativeFieldInfoPtr_ImpactSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "ImpactSources");
			FXManager.NativeFieldInfoPtr_PunchParticlePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchParticlePrefab");
			FXManager.NativeFieldInfoPtr_BulletTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "BulletTrail");
			FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674084);
			FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674085);
			FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674086);
			FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674087);
			FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674088);
			FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674089);
			FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674090);
			FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674091);
			FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674092);
			FXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100674093);
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00194F24 File Offset: 0x00193124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184260, XrefRangeEnd = 184263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00194F60 File Offset: 0x00193160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184300, RefRangeEnd = 184303, XrefRangeStart = 184263, XrefRangeEnd = 184300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateImpactFX(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00194FA4 File Offset: 0x001931A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184338, RefRangeEnd = 184339, XrefRangeStart = 184303, XrefRangeEnd = 184338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref dir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref speed;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref range;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mask;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x0019501C File Offset: 0x0019321C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184372, RefRangeEnd = 184373, XrefRangeStart = 184339, XrefRangeEnd = 184372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref volume;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x0019507C File Offset: 0x0019327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184373, XrefRangeEnd = 184380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x001950DC File Offset: 0x001932DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184380, XrefRangeEnd = 184388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetImpactSound(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x0019512C File Offset: 0x0019332C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184388, XrefRangeEnd = 184396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetImpactParticles(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x0019517C File Offset: 0x0019337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184396, XrefRangeEnd = 184414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x001951BC File Offset: 0x001933BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184414, XrefRangeEnd = 184415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip GetRandomClip(Il2CppReferenceArray<AudioClip> clips)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00195200 File Offset: 0x00193400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184415, XrefRangeEnd = 184418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00029106 File Offset: 0x00027306
		public FXManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x0019523C File Offset: 0x0019343C
		// (set) Token: 0x0600561D RID: 22045 RVA: 0x0002910F File Offset: 0x0002730F
		public unsafe Il2CppReferenceArray<AudioClip> PunchImpactsClips
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600561E RID: 22046 RVA: 0x0019526C File Offset: 0x0019346C
		// (set) Token: 0x0600561F RID: 22047 RVA: 0x0002912E File Offset: 0x0002732E
		public unsafe Il2CppReferenceArray<AudioClip> SlashImpactClips
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06005620 RID: 22048 RVA: 0x0019529C File Offset: 0x0019349C
		// (set) Token: 0x06005621 RID: 22049 RVA: 0x0002914D File Offset: 0x0002734D
		public unsafe Il2CppReferenceArray<AudioSourceController> ImpactSources
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x001952CC File Offset: 0x001934CC
		// (set) Token: 0x06005623 RID: 22051 RVA: 0x0002916C File Offset: 0x0002736C
		public unsafe GameObject PunchParticlePrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06005624 RID: 22052 RVA: 0x001952FC File Offset: 0x001934FC
		// (set) Token: 0x06005625 RID: 22053 RVA: 0x0002918B File Offset: 0x0002738B
		public unsafe TrailRenderer BulletTrail
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A40 RID: 14912
		private static readonly System.IntPtr NativeFieldInfoPtr_PunchImpactsClips;

		// Token: 0x04003A41 RID: 14913
		private static readonly System.IntPtr NativeFieldInfoPtr_SlashImpactClips;

		// Token: 0x04003A42 RID: 14914
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactSources;

		// Token: 0x04003A43 RID: 14915
		private static readonly System.IntPtr NativeFieldInfoPtr_PunchParticlePrefab;

		// Token: 0x04003A44 RID: 14916
		private static readonly System.IntPtr NativeFieldInfoPtr_BulletTrail;

		// Token: 0x04003A45 RID: 14917
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003A46 RID: 14918
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_0;

		// Token: 0x04003A47 RID: 14919
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0;

		// Token: 0x04003A48 RID: 14920
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0;

		// Token: 0x04003A49 RID: 14921
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0;

		// Token: 0x04003A4A RID: 14922
		private static readonly System.IntPtr NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_0;

		// Token: 0x04003A4B RID: 14923
		private static readonly System.IntPtr NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_0;

		// Token: 0x04003A4C RID: 14924
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x04003A4D RID: 14925
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0;

		// Token: 0x04003A4E RID: 14926
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A03 RID: 2563
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D118 RID: 53528 RVA: 0x0032921C File Offset: 0x0032741C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr);
				FXManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9");
				FXManager.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9__12_0");
				FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100674095);
				FXManager.__c.NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100674096);
			}

			// Token: 0x0600D119 RID: 53529 RVA: 0x00329298 File Offset: 0x00327498
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D11A RID: 53530 RVA: 0x003292D4 File Offset: 0x003274D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184242, XrefRangeEnd = 184243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSource_b__12_0(AudioSourceController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D11B RID: 53531 RVA: 0x0006566A File Offset: 0x0006386A
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D4 RID: 16596
			// (get) Token: 0x0600D11C RID: 53532 RVA: 0x00329324 File Offset: 0x00327524
			// (set) Token: 0x0600D11D RID: 53533 RVA: 0x00065673 File Offset: 0x00063873
			public unsafe static FXManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D5 RID: 16597
			// (get) Token: 0x0600D11E RID: 53534 RVA: 0x0032934C File Offset: 0x0032754C
			// (set) Token: 0x0600D11F RID: 53535 RVA: 0x00065685 File Offset: 0x00063885
			public unsafe static Il2CppSystem.Func<AudioSourceController, bool> __9__12_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D67 RID: 36199
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D68 RID: 36200
			private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04008D69 RID: 36201
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D6A RID: 36202
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSource_b__12_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x02000A04 RID: 2564
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D120 RID: 53536 RVA: 0x00329374 File Offset: 0x00327574
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr);
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "trail");
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "start");
				FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "maxDistance");
				FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, 100674097);
				FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, 100674098);
			}

			// Token: 0x0600D121 RID: 53537 RVA: 0x00329404 File Offset: 0x00327604
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D122 RID: 53538 RVA: 0x00329440 File Offset: 0x00327640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184255, XrefRangeEnd = 184260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D123 RID: 53539 RVA: 0x00065697 File Offset: 0x00063897
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D6 RID: 16598
			// (get) Token: 0x0600D124 RID: 53540 RVA: 0x00329480 File Offset: 0x00327680
			// (set) Token: 0x0600D125 RID: 53541 RVA: 0x000656A0 File Offset: 0x000638A0
			public unsafe TrailRenderer trail
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D7 RID: 16599
			// (get) Token: 0x0600D126 RID: 53542 RVA: 0x003294B0 File Offset: 0x003276B0
			// (set) Token: 0x0600D127 RID: 53543 RVA: 0x000656BF File Offset: 0x000638BF
			public unsafe Vector3 start
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170040D8 RID: 16600
			// (get) Token: 0x0600D128 RID: 53544 RVA: 0x003294D8 File Offset: 0x003276D8
			// (set) Token: 0x0600D129 RID: 53545 RVA: 0x000656DA File Offset: 0x000638DA
			public unsafe float maxDistance
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.NativeFieldInfoPtr_maxDistance)) = value;
				}
			}

			// Token: 0x04008D6B RID: 36203
			private static readonly System.IntPtr NativeFieldInfoPtr_trail;

			// Token: 0x04008D6C RID: 36204
			private static readonly System.IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04008D6D RID: 36205
			private static readonly System.IntPtr NativeFieldInfoPtr_maxDistance;

			// Token: 0x04008D6E RID: 36206
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D6F RID: 36207
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CA5 RID: 3237
			[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass7_0+<<CreateBulletTrail>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E861 RID: 59489 RVA: 0x0036AF18 File Offset: 0x00369118
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0>.NativeClassPtr, "<<CreateBulletTrail>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674099);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674100);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674101);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674102);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674103);
					FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674104);
				}

				// Token: 0x0600E862 RID: 59490 RVA: 0x0036AFF8 File Offset: 0x003691F8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E863 RID: 59491 RVA: 0x0036B040 File Offset: 0x00369240
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E864 RID: 59492 RVA: 0x0036B074 File Offset: 0x00369274
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184243, XrefRangeEnd = 184250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047C7 RID: 18375
				// (get) Token: 0x0600E865 RID: 59493 RVA: 0x0036B0B0 File Offset: 0x003692B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E866 RID: 59494 RVA: 0x0036B0F0 File Offset: 0x003692F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184250, XrefRangeEnd = 184255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047C8 RID: 18376
				// (get) Token: 0x0600E867 RID: 59495 RVA: 0x0036B124 File Offset: 0x00369324
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E868 RID: 59496 RVA: 0x00070FD5 File Offset: 0x0006F1D5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047C4 RID: 18372
				// (get) Token: 0x0600E869 RID: 59497 RVA: 0x0036B164 File Offset: 0x00369364
				// (set) Token: 0x0600E86A RID: 59498 RVA: 0x00070FDE File Offset: 0x0006F1DE
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047C5 RID: 18373
				// (get) Token: 0x0600E86B RID: 59499 RVA: 0x0036B18C File Offset: 0x0036938C
				// (set) Token: 0x0600E86C RID: 59500 RVA: 0x00070FF9 File Offset: 0x0006F1F9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047C6 RID: 18374
				// (get) Token: 0x0600E86D RID: 59501 RVA: 0x0036B1BC File Offset: 0x003693BC
				// (set) Token: 0x0600E86E RID: 59502 RVA: 0x00071018 File Offset: 0x0006F218
				public unsafe FXManager.__c__DisplayClass7_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c__DisplayClass7_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B92 RID: 39826
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B93 RID: 39827
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B94 RID: 39828
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B95 RID: 39829
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B96 RID: 39830
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B97 RID: 39831
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B98 RID: 39832
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B99 RID: 39833
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B9A RID: 39834
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
