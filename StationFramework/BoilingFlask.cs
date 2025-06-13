using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005A7 RID: 1447
	public class BoilingFlask : Fillable
	{
		// Token: 0x06007E6F RID: 32367 RVA: 0x00221AC8 File Offset: 0x0021FCC8
		// Note: this type is marked as 'beforefieldinit'.
		static BoilingFlask()
		{
			Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "BoilingFlask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr);
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX_VELOCITY");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_ACCELERATION");
			BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OVERHEAT_TIME");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperature>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperatureVelocity>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<OverheatScale>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<Recipe>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr_LockTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LockTemperature");
			BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSoundPitchCurve");
			BoilingFlask.NativeFieldInfoPtr_LabelJitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LabelJitterScale");
			BoilingFlask.NativeFieldInfoPtr_Burner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "Burner");
			BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureCanvas");
			BoilingFlask.NativeFieldInfoPtr_TemperatureLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureLabel");
			BoilingFlask.NativeFieldInfoPtr_TemperatureSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureSlider");
			BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureRangeIndicator");
			BoilingFlask.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "SmokeParticles");
			BoilingFlask.NativeFieldInfoPtr_BoilSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSound");
			BoilingFlask.NativeFieldInfoPtr_OverheatMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OverheatMesh");
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679245);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679246);
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679247);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679248);
			BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679249);
			BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679250);
			BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679251);
			BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679252);
			BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679253);
			BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679254);
			BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679255);
			BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679256);
			BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679257);
			BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679258);
			BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679259);
			BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679260);
			BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100679261);
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x00221DC8 File Offset: 0x0021FFC8
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x00221E04 File Offset: 0x00220004
		public unsafe float CurrentTemperature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31489, RefRangeEnd = 31490, XrefRangeStart = 31489, XrefRangeEnd = 31490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 31490, RefRangeEnd = 31493, XrefRangeStart = 31490, XrefRangeEnd = 31493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x00221E44 File Offset: 0x00220044
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x00221E80 File Offset: 0x00220080
		public unsafe float CurrentTemperatureVelocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31493, RefRangeEnd = 31494, XrefRangeStart = 31493, XrefRangeEnd = 31494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x00221EC0 File Offset: 0x002200C0
		public unsafe bool IsTemperatureInRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 241107, RefRangeEnd = 241108, XrefRangeStart = 241103, XrefRangeEnd = 241107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007E75 RID: 32373 RVA: 0x00221EFC File Offset: 0x002200FC
		// (set) Token: 0x06007E76 RID: 32374 RVA: 0x00221F38 File Offset: 0x00220138
		public unsafe float OverheatScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007E77 RID: 32375 RVA: 0x00221F78 File Offset: 0x00220178
		// (set) Token: 0x06007E78 RID: 32376 RVA: 0x00221FB8 File Offset: 0x002201B8
		public unsafe StationRecipe Recipe
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x00221FFC File Offset: 0x002201FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241108, XrefRangeEnd = 241139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x00222030 File Offset: 0x00220230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241139, XrefRangeEnd = 241148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x00222064 File Offset: 0x00220264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241163, RefRangeEnd = 241164, XrefRangeStart = 241148, XrefRangeEnd = 241163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x00222098 File Offset: 0x00220298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241164, XrefRangeEnd = 241172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSmoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x002220CC File Offset: 0x002202CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241175, RefRangeEnd = 241178, XrefRangeStart = 241172, XrefRangeEnd = 241175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0022210C File Offset: 0x0022030C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31490, RefRangeEnd = 31493, XrefRangeStart = 31490, XrefRangeEnd = 31493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemperature(float temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0022214C File Offset: 0x0022034C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241189, RefRangeEnd = 241192, XrefRangeStart = 241178, XrefRangeEnd = 241189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x00222190 File Offset: 0x00220390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241192, XrefRangeEnd = 241200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoilingFlask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x0003BB93 File Offset: 0x00039D93
		public BoilingFlask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x002221CC File Offset: 0x002203CC
		// (set) Token: 0x06007E83 RID: 32387 RVA: 0x0003BB9C File Offset: 0x00039D9C
		public unsafe static float TEMPERATURE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x002221E8 File Offset: 0x002203E8
		// (set) Token: 0x06007E85 RID: 32389 RVA: 0x0003BBAA File Offset: 0x00039DAA
		public unsafe float TEMPERATURE_MAX_VELOCITY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY)) = value;
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x00222210 File Offset: 0x00220410
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x0003BBC5 File Offset: 0x00039DC5
		public unsafe float TEMPERATURE_ACCELERATION
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION)) = value;
			}
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x00222238 File Offset: 0x00220438
		// (set) Token: 0x06007E89 RID: 32393 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		public unsafe static float OVERHEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06007E8A RID: 32394 RVA: 0x00222254 File Offset: 0x00220454
		// (set) Token: 0x06007E8B RID: 32395 RVA: 0x0003BBEE File Offset: 0x00039DEE
		public unsafe float _CurrentTemperature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField)) = value;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06007E8C RID: 32396 RVA: 0x0022227C File Offset: 0x0022047C
		// (set) Token: 0x06007E8D RID: 32397 RVA: 0x0003BC09 File Offset: 0x00039E09
		public unsafe float _CurrentTemperatureVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x002222A4 File Offset: 0x002204A4
		// (set) Token: 0x06007E8F RID: 32399 RVA: 0x0003BC24 File Offset: 0x00039E24
		public unsafe float _OverheatScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x002222CC File Offset: 0x002204CC
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x0003BC3F File Offset: 0x00039E3F
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x002222FC File Offset: 0x002204FC
		// (set) Token: 0x06007E93 RID: 32403 RVA: 0x0003BC5E File Offset: 0x00039E5E
		public unsafe bool LockTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature)) = value;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06007E94 RID: 32404 RVA: 0x00222324 File Offset: 0x00220524
		// (set) Token: 0x06007E95 RID: 32405 RVA: 0x0003BC79 File Offset: 0x00039E79
		public unsafe AnimationCurve BoilSoundPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06007E96 RID: 32406 RVA: 0x00222354 File Offset: 0x00220554
		// (set) Token: 0x06007E97 RID: 32407 RVA: 0x0003BC98 File Offset: 0x00039E98
		public unsafe float LabelJitterScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale)) = value;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06007E98 RID: 32408 RVA: 0x0022237C File Offset: 0x0022057C
		// (set) Token: 0x06007E99 RID: 32409 RVA: 0x0003BCB3 File Offset: 0x00039EB3
		public unsafe BunsenBurner Burner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunsenBurner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x002223AC File Offset: 0x002205AC
		// (set) Token: 0x06007E9B RID: 32411 RVA: 0x0003BCD2 File Offset: 0x00039ED2
		public unsafe Canvas TemperatureCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x002223DC File Offset: 0x002205DC
		// (set) Token: 0x06007E9D RID: 32413 RVA: 0x0003BCF1 File Offset: 0x00039EF1
		public unsafe TextMeshProUGUI TemperatureLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x0022240C File Offset: 0x0022060C
		// (set) Token: 0x06007E9F RID: 32415 RVA: 0x0003BD10 File Offset: 0x00039F10
		public unsafe Slider TemperatureSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x0022243C File Offset: 0x0022063C
		// (set) Token: 0x06007EA1 RID: 32417 RVA: 0x0003BD2F File Offset: 0x00039F2F
		public unsafe RectTransform TemperatureRangeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x0022246C File Offset: 0x0022066C
		// (set) Token: 0x06007EA3 RID: 32419 RVA: 0x0003BD4E File Offset: 0x00039F4E
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0022249C File Offset: 0x0022069C
		// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x0003BD6D File Offset: 0x00039F6D
		public unsafe AudioSourceController BoilSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x002224CC File Offset: 0x002206CC
		// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x0003BD8C File Offset: 0x00039F8C
		public unsafe MeshRenderer OverheatMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400561F RID: 22047
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX;

		// Token: 0x04005620 RID: 22048
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY;

		// Token: 0x04005621 RID: 22049
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_ACCELERATION;

		// Token: 0x04005622 RID: 22050
		private static readonly IntPtr NativeFieldInfoPtr_OVERHEAT_TIME;

		// Token: 0x04005623 RID: 22051
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperature_k__BackingField;

		// Token: 0x04005624 RID: 22052
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField;

		// Token: 0x04005625 RID: 22053
		private static readonly IntPtr NativeFieldInfoPtr__OverheatScale_k__BackingField;

		// Token: 0x04005626 RID: 22054
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04005627 RID: 22055
		private static readonly IntPtr NativeFieldInfoPtr_LockTemperature;

		// Token: 0x04005628 RID: 22056
		private static readonly IntPtr NativeFieldInfoPtr_BoilSoundPitchCurve;

		// Token: 0x04005629 RID: 22057
		private static readonly IntPtr NativeFieldInfoPtr_LabelJitterScale;

		// Token: 0x0400562A RID: 22058
		private static readonly IntPtr NativeFieldInfoPtr_Burner;

		// Token: 0x0400562B RID: 22059
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureCanvas;

		// Token: 0x0400562C RID: 22060
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureLabel;

		// Token: 0x0400562D RID: 22061
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureSlider;

		// Token: 0x0400562E RID: 22062
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureRangeIndicator;

		// Token: 0x0400562F RID: 22063
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x04005630 RID: 22064
		private static readonly IntPtr NativeFieldInfoPtr_BoilSound;

		// Token: 0x04005631 RID: 22065
		private static readonly IntPtr NativeFieldInfoPtr_OverheatMesh;

		// Token: 0x04005632 RID: 22066
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0;

		// Token: 0x04005633 RID: 22067
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0;

		// Token: 0x04005634 RID: 22068
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0;

		// Token: 0x04005635 RID: 22069
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0;

		// Token: 0x04005636 RID: 22070
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0;

		// Token: 0x04005637 RID: 22071
		private static readonly IntPtr NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0;

		// Token: 0x04005638 RID: 22072
		private static readonly IntPtr NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0;

		// Token: 0x04005639 RID: 22073
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x0400563A RID: 22074
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x0400563B RID: 22075
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400563C RID: 22076
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400563D RID: 22077
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x0400563E RID: 22078
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSmoke_Private_Void_0;

		// Token: 0x0400563F RID: 22079
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0;

		// Token: 0x04005640 RID: 22080
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0;

		// Token: 0x04005641 RID: 22081
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04005642 RID: 22082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
