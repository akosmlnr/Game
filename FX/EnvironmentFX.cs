using System;
using Il2CppFunly.SkyStudio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppVolumetricFogAndMist2;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000417 RID: 1047
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x060055D0 RID: 21968 RVA: 0x00194488 File Offset: 0x00192688
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentFX()
		{
			Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "EnvironmentFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr);
			EnvironmentFX.NativeFieldInfoPtr_windZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "windZone");
			EnvironmentFX.NativeFieldInfoPtr_timeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "timeOfDayController");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFog");
			EnvironmentFX.NativeFieldInfoPtr_SunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "SunLight");
			EnvironmentFX.NativeFieldInfoPtr_MoonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "MoonLight");
			EnvironmentFX.NativeFieldInfoPtr_fogColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceCurve");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogColor");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogDirectionalIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogColor");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "godRayIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_contrastCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contrastCurve");
			EnvironmentFX.NativeFieldInfoPtr_contractMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contractMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_saturationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationCurve");
			EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_grassMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassMat");
			EnvironmentFX.NativeFieldInfoPtr_grassColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeMat");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeColorCurve");
			EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "environmentalBrightnessCurve");
			EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "bloomThreshholdCurve");
			EnvironmentFX.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "started");
			EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "FogEndDistanceController");
			EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674078);
			EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674079);
			EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674080);
			EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674081);
			EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674082);
			EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100674083);
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x00194760 File Offset: 0x00192960
		public unsafe float normalizedEnvironmentalBrightness
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 184162, RefRangeEnd = 184165, XrefRangeStart = 184153, XrefRangeEnd = 184162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x0019479C File Offset: 0x0019299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184165, XrefRangeEnd = 184183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x001947D8 File Offset: 0x001929D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184183, XrefRangeEnd = 184193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x0019480C File Offset: 0x00192A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184235, RefRangeEnd = 184236, XrefRangeStart = 184193, XrefRangeEnd = 184235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00194840 File Offset: 0x00192A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184236, XrefRangeEnd = 184239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x0019487C File Offset: 0x00192A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184239, XrefRangeEnd = 184242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00028DB1 File Offset: 0x00026FB1
		public EnvironmentFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x001948B8 File Offset: 0x00192AB8
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x00028DBA File Offset: 0x00026FBA
		public unsafe WindZone windZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x001948E8 File Offset: 0x00192AE8
		// (set) Token: 0x060055DB RID: 21979 RVA: 0x00028DD9 File Offset: 0x00026FD9
		public unsafe TimeOfDayController timeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x060055DC RID: 21980 RVA: 0x00194918 File Offset: 0x00192B18
		// (set) Token: 0x060055DD RID: 21981 RVA: 0x00028DF8 File Offset: 0x00026FF8
		public unsafe VolumetricFog VolumetricFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x060055DE RID: 21982 RVA: 0x00194948 File Offset: 0x00192B48
		// (set) Token: 0x060055DF RID: 21983 RVA: 0x00028E17 File Offset: 0x00027017
		public unsafe Light SunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x00194978 File Offset: 0x00192B78
		// (set) Token: 0x060055E1 RID: 21985 RVA: 0x00028E36 File Offset: 0x00027036
		public unsafe Light MoonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x060055E2 RID: 21986 RVA: 0x001949A8 File Offset: 0x00192BA8
		// (set) Token: 0x060055E3 RID: 21987 RVA: 0x00028E55 File Offset: 0x00027055
		public unsafe Gradient fogColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x001949D8 File Offset: 0x00192BD8
		// (set) Token: 0x060055E5 RID: 21989 RVA: 0x00028E74 File Offset: 0x00027074
		public unsafe AnimationCurve fogEndDistanceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x00194A08 File Offset: 0x00192C08
		// (set) Token: 0x060055E7 RID: 21991 RVA: 0x00028E93 File Offset: 0x00027093
		public unsafe float fogEndDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier)) = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060055E8 RID: 21992 RVA: 0x00194A30 File Offset: 0x00192C30
		// (set) Token: 0x060055E9 RID: 21993 RVA: 0x00028EAE File Offset: 0x000270AE
		public unsafe Gradient HeightFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060055EA RID: 21994 RVA: 0x00194A60 File Offset: 0x00192C60
		// (set) Token: 0x060055EB RID: 21995 RVA: 0x00028ECD File Offset: 0x000270CD
		public unsafe AnimationCurve HeightFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060055EC RID: 21996 RVA: 0x00194A90 File Offset: 0x00192C90
		// (set) Token: 0x060055ED RID: 21997 RVA: 0x00028EEC File Offset: 0x000270EC
		public unsafe float HeightFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x00194AB8 File Offset: 0x00192CB8
		// (set) Token: 0x060055EF RID: 21999 RVA: 0x00028F07 File Offset: 0x00027107
		public unsafe AnimationCurve HeightFogDirectionalIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x00194AE8 File Offset: 0x00192CE8
		// (set) Token: 0x060055F1 RID: 22001 RVA: 0x00028F26 File Offset: 0x00027126
		public unsafe Gradient VolumetricFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x00194B18 File Offset: 0x00192D18
		// (set) Token: 0x060055F3 RID: 22003 RVA: 0x00028F45 File Offset: 0x00027145
		public unsafe AnimationCurve VolumetricFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x00194B48 File Offset: 0x00192D48
		// (set) Token: 0x060055F5 RID: 22005 RVA: 0x00028F64 File Offset: 0x00027164
		public unsafe float VolumetricFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x00194B70 File Offset: 0x00192D70
		// (set) Token: 0x060055F7 RID: 22007 RVA: 0x00028F7F File Offset: 0x0002717F
		public unsafe AnimationCurve godRayIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x00194BA0 File Offset: 0x00192DA0
		// (set) Token: 0x060055F9 RID: 22009 RVA: 0x00028F9E File Offset: 0x0002719E
		public unsafe AnimationCurve contrastCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x00194BD0 File Offset: 0x00192DD0
		// (set) Token: 0x060055FB RID: 22011 RVA: 0x00028FBD File Offset: 0x000271BD
		public unsafe float contractMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier)) = value;
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x00194BF8 File Offset: 0x00192DF8
		// (set) Token: 0x060055FD RID: 22013 RVA: 0x00028FD8 File Offset: 0x000271D8
		public unsafe AnimationCurve saturationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x00194C28 File Offset: 0x00192E28
		// (set) Token: 0x060055FF RID: 22015 RVA: 0x00028FF7 File Offset: 0x000271F7
		public unsafe float saturationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier)) = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x00194C50 File Offset: 0x00192E50
		// (set) Token: 0x06005601 RID: 22017 RVA: 0x00029012 File Offset: 0x00027212
		public unsafe Material grassMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x00194C80 File Offset: 0x00192E80
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x00029031 File Offset: 0x00027231
		public unsafe Gradient grassColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x00194CB0 File Offset: 0x00192EB0
		// (set) Token: 0x06005605 RID: 22021 RVA: 0x00029050 File Offset: 0x00027250
		public unsafe Material distanceTreeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x00194CE0 File Offset: 0x00192EE0
		// (set) Token: 0x06005607 RID: 22023 RVA: 0x0002906F File Offset: 0x0002726F
		public unsafe AnimationCurve distanceTreeColorCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x00194D10 File Offset: 0x00192F10
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x0002908E File Offset: 0x0002728E
		public unsafe AnimationCurve environmentalBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x00194D40 File Offset: 0x00192F40
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x000290AD File Offset: 0x000272AD
		public unsafe AnimationCurve bloomThreshholdCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x00194D70 File Offset: 0x00192F70
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x000290CC File Offset: 0x000272CC
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x00194D98 File Offset: 0x00192F98
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x000290E7 File Offset: 0x000272E7
		public unsafe FloatSmoother FogEndDistanceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeFieldInfoPtr_windZone;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDayController;

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFog;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeFieldInfoPtr_SunLight;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeFieldInfoPtr_MoonLight;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeFieldInfoPtr_fogColorGradient;

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceCurve;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceMultiplier;

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogColor;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityCurve;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityMultiplier;

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve;

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogColor;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityCurve;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityMultiplier;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeFieldInfoPtr_godRayIntensityCurve;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeFieldInfoPtr_contrastCurve;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeFieldInfoPtr_contractMultiplier;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeFieldInfoPtr_saturationCurve;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeFieldInfoPtr_saturationMultiplier;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeFieldInfoPtr_grassMat;

		// Token: 0x04003A33 RID: 14899
		private static readonly IntPtr NativeFieldInfoPtr_grassColorGradient;

		// Token: 0x04003A34 RID: 14900
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeMat;

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeColorCurve;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeFieldInfoPtr_environmentalBrightnessCurve;

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeFieldInfoPtr_bloomThreshholdCurve;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeFieldInfoPtr_FogEndDistanceController;

		// Token: 0x04003A3A RID: 14906
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0;

		// Token: 0x04003A3B RID: 14907
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003A3C RID: 14908
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003A3D RID: 14909
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04003A3E RID: 14910
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003A3F RID: 14911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
