using System;
using Il2CppBeautify.Universal;
using Il2CppCorgiGodRays;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x0200041A RID: 1050
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x06005643 RID: 22083 RVA: 0x00195784 File Offset: 0x00193984
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingManager()
		{
			Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PostProcessingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr);
			PostProcessingManager.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GlobalVolume");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultIntensity");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultSmoothness");
			PostProcessingManager.NativeFieldInfoPtr_MinBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MinBlur");
			PostProcessingManager.NativeFieldInfoPtr_MaxBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MaxBlur");
			PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ChromaticAberrationController");
			PostProcessingManager.NativeFieldInfoPtr_SaturationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "SaturationController");
			PostProcessingManager.NativeFieldInfoPtr_BloomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "BloomController");
			PostProcessingManager.NativeFieldInfoPtr_ColorFilterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorFilterController");
			PostProcessingManager.NativeFieldInfoPtr_vig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "vig");
			PostProcessingManager.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "DoF");
			PostProcessingManager.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GodRays");
			PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorAdjustments");
			PostProcessingManager.NativeFieldInfoPtr_beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "beautifySettings");
			PostProcessingManager.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "bloom");
			PostProcessingManager.NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "chromaticAberration");
			PostProcessingManager.NativeFieldInfoPtr_colorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "colorAdjustments");
			PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674110);
			PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674111);
			PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674112);
			PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674113);
			PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674114);
			PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674115);
			PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674116);
			PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674117);
			PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674118);
			PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674119);
			PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100674120);
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x001959E4 File Offset: 0x00193BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184522, XrefRangeEnd = 184554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00195A20 File Offset: 0x00193C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184554, XrefRangeEnd = 184555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00195A54 File Offset: 0x00193C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184564, RefRangeEnd = 184565, XrefRangeStart = 184555, XrefRangeEnd = 184564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00195A88 File Offset: 0x00193C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184566, RefRangeEnd = 184567, XrefRangeStart = 184565, XrefRangeEnd = 184566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideVignette(float intensity, float smoothness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothness;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00195AD4 File Offset: 0x00193CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184567, XrefRangeEnd = 184568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVignette()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00195B08 File Offset: 0x00193D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184568, XrefRangeEnd = 184569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGodRayIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00195B48 File Offset: 0x00193D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184569, XrefRangeEnd = 184570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContrast(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00195B88 File Offset: 0x00193D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184570, XrefRangeEnd = 184572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSaturation(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00195BC8 File Offset: 0x00193DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184572, XrefRangeEnd = 184573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBloomThreshold(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00195C08 File Offset: 0x00193E08
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 184575, RefRangeEnd = 184584, XrefRangeStart = 184573, XrefRangeEnd = 184575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlur(float blurLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blurLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00195C48 File Offset: 0x00193E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184584, XrefRangeEnd = 184587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x000292E8 File Offset: 0x000274E8
		public PostProcessingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x00195C84 File Offset: 0x00193E84
		// (set) Token: 0x06005651 RID: 22097 RVA: 0x000292F1 File Offset: 0x000274F1
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x00195CB4 File Offset: 0x00193EB4
		// (set) Token: 0x06005653 RID: 22099 RVA: 0x00029310 File Offset: 0x00027510
		public unsafe float Vig_DefaultIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity)) = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06005654 RID: 22100 RVA: 0x00195CDC File Offset: 0x00193EDC
		// (set) Token: 0x06005655 RID: 22101 RVA: 0x0002932B File Offset: 0x0002752B
		public unsafe float Vig_DefaultSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness)) = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06005656 RID: 22102 RVA: 0x00195D04 File Offset: 0x00193F04
		// (set) Token: 0x06005657 RID: 22103 RVA: 0x00029346 File Offset: 0x00027546
		public unsafe float MinBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur)) = value;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06005658 RID: 22104 RVA: 0x00195D2C File Offset: 0x00193F2C
		// (set) Token: 0x06005659 RID: 22105 RVA: 0x00029361 File Offset: 0x00027561
		public unsafe float MaxBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur)) = value;
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600565A RID: 22106 RVA: 0x00195D54 File Offset: 0x00193F54
		// (set) Token: 0x0600565B RID: 22107 RVA: 0x0002937C File Offset: 0x0002757C
		public unsafe FloatSmoother ChromaticAberrationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x00195D84 File Offset: 0x00193F84
		// (set) Token: 0x0600565D RID: 22109 RVA: 0x0002939B File Offset: 0x0002759B
		public unsafe FloatSmoother SaturationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x0600565E RID: 22110 RVA: 0x00195DB4 File Offset: 0x00193FB4
		// (set) Token: 0x0600565F RID: 22111 RVA: 0x000293BA File Offset: 0x000275BA
		public unsafe FloatSmoother BloomController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x00195DE4 File Offset: 0x00193FE4
		// (set) Token: 0x06005661 RID: 22113 RVA: 0x000293D9 File Offset: 0x000275D9
		public unsafe HDRColorSmoother ColorFilterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x00195E14 File Offset: 0x00194014
		// (set) Token: 0x06005663 RID: 22115 RVA: 0x000293F8 File Offset: 0x000275F8
		public unsafe Vignette vig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vignette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x00195E44 File Offset: 0x00194044
		// (set) Token: 0x06005665 RID: 22117 RVA: 0x00029417 File Offset: 0x00027617
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06005666 RID: 22118 RVA: 0x00195E74 File Offset: 0x00194074
		// (set) Token: 0x06005667 RID: 22119 RVA: 0x00029436 File Offset: 0x00027636
		public unsafe GodRaysVolume GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GodRaysVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06005668 RID: 22120 RVA: 0x00195EA4 File Offset: 0x001940A4
		// (set) Token: 0x06005669 RID: 22121 RVA: 0x00029455 File Offset: 0x00027655
		public unsafe ColorAdjustments ColorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600566A RID: 22122 RVA: 0x00195ED4 File Offset: 0x001940D4
		// (set) Token: 0x0600566B RID: 22123 RVA: 0x00029474 File Offset: 0x00027674
		public unsafe Beautify beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x00195F04 File Offset: 0x00194104
		// (set) Token: 0x0600566D RID: 22125 RVA: 0x00029493 File Offset: 0x00027693
		public unsafe Bloom bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bloom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600566E RID: 22126 RVA: 0x00195F34 File Offset: 0x00194134
		// (set) Token: 0x0600566F RID: 22127 RVA: 0x000294B2 File Offset: 0x000276B2
		public unsafe ChromaticAberration chromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x00195F64 File Offset: 0x00194164
		// (set) Token: 0x06005671 RID: 22129 RVA: 0x000294D1 File Offset: 0x000276D1
		public unsafe ColorAdjustments colorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A5F RID: 14943
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003A60 RID: 14944
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultIntensity;

		// Token: 0x04003A61 RID: 14945
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultSmoothness;

		// Token: 0x04003A62 RID: 14946
		private static readonly IntPtr NativeFieldInfoPtr_MinBlur;

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeFieldInfoPtr_MaxBlur;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberrationController;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeFieldInfoPtr_SaturationController;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeFieldInfoPtr_BloomController;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeFieldInfoPtr_ColorFilterController;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeFieldInfoPtr_vig;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeFieldInfoPtr_ColorAdjustments;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeFieldInfoPtr_beautifySettings;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeFieldInfoPtr_bloom;

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeFieldInfoPtr_chromaticAberration;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeFieldInfoPtr_colorAdjustments;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr_ResetVignette_Public_Void_0;

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeMethodInfoPtr_SetContrast_Public_Void_Single_0;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeMethodInfoPtr_SetBlur_Public_Void_Single_0;

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
