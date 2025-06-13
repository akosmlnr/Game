using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005D9 RID: 1497
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x06008280 RID: 33408 RVA: 0x00230608 File Offset: 0x0022E808
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cuke()
		{
			Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Cuke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr);
			Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<IsDrinking>k__BackingField");
			Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "BaseEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "MinEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ConsecutiveReduction");
			Equippable_Cuke.NativeFieldInfoPtr_HealthGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "HealthGain");
			Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "AnimationDuration");
			Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ClearDrugEffects");
			Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "PseudoProduct");
			Equippable_Cuke.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenAnim");
			Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "DrinkAnim");
			Equippable_Cuke.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenSound");
			Equippable_Cuke.NativeFieldInfoPtr_SlurpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "SlurpSound");
			Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "TrashPrefab");
			Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679776);
			Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679777);
			Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679778);
			Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679779);
			Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679780);
			Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679781);
			Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679782);
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x06008281 RID: 33409 RVA: 0x002307C8 File Offset: 0x0022E9C8
		// (set) Token: 0x06008282 RID: 33410 RVA: 0x00230804 File Offset: 0x0022EA04
		public unsafe bool IsDrinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00230844 File Offset: 0x0022EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248093, XrefRangeEnd = 248110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00230880 File Offset: 0x0022EA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248110, XrefRangeEnd = 248116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Drink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x002308B4 File Offset: 0x0022EAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248155, RefRangeEnd = 248156, XrefRangeStart = 248116, XrefRangeEnd = 248155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x002308E8 File Offset: 0x0022EAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248156, XrefRangeEnd = 248159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cuke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x00230924 File Offset: 0x0022EB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248159, XrefRangeEnd = 248164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0003DA25 File Offset: 0x0003BC25
		public Equippable_Cuke(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x06008289 RID: 33417 RVA: 0x00230964 File Offset: 0x0022EB64
		// (set) Token: 0x0600828A RID: 33418 RVA: 0x0003DA2E File Offset: 0x0003BC2E
		public unsafe bool _IsDrinking_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600828B RID: 33419 RVA: 0x0023098C File Offset: 0x0022EB8C
		// (set) Token: 0x0600828C RID: 33420 RVA: 0x0003DA49 File Offset: 0x0003BC49
		public unsafe float BaseEnergyGain
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain)) = value;
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600828D RID: 33421 RVA: 0x002309B4 File Offset: 0x0022EBB4
		// (set) Token: 0x0600828E RID: 33422 RVA: 0x0003DA64 File Offset: 0x0003BC64
		public unsafe float MinEnergyGain
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain)) = value;
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600828F RID: 33423 RVA: 0x002309DC File Offset: 0x0022EBDC
		// (set) Token: 0x06008290 RID: 33424 RVA: 0x0003DA7F File Offset: 0x0003BC7F
		public unsafe float ConsecutiveReduction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction)) = value;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x00230A04 File Offset: 0x0022EC04
		// (set) Token: 0x06008292 RID: 33426 RVA: 0x0003DA9A File Offset: 0x0003BC9A
		public unsafe float HealthGain
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain)) = value;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x06008293 RID: 33427 RVA: 0x00230A2C File Offset: 0x0022EC2C
		// (set) Token: 0x06008294 RID: 33428 RVA: 0x0003DAB5 File Offset: 0x0003BCB5
		public unsafe float AnimationDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x06008295 RID: 33429 RVA: 0x00230A54 File Offset: 0x0022EC54
		// (set) Token: 0x06008296 RID: 33430 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
		public unsafe bool ClearDrugEffects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects)) = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x06008297 RID: 33431 RVA: 0x00230A7C File Offset: 0x0022EC7C
		// (set) Token: 0x06008298 RID: 33432 RVA: 0x0003DAEB File Offset: 0x0003BCEB
		public unsafe ProductDefinition PseudoProduct
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06008299 RID: 33433 RVA: 0x00230AAC File Offset: 0x0022ECAC
		// (set) Token: 0x0600829A RID: 33434 RVA: 0x0003DB0A File Offset: 0x0003BD0A
		public unsafe Animation OpenAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600829B RID: 33435 RVA: 0x00230ADC File Offset: 0x0022ECDC
		// (set) Token: 0x0600829C RID: 33436 RVA: 0x0003DB29 File Offset: 0x0003BD29
		public unsafe Animation DrinkAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x00230B0C File Offset: 0x0022ED0C
		// (set) Token: 0x0600829E RID: 33438 RVA: 0x0003DB48 File Offset: 0x0003BD48
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600829F RID: 33439 RVA: 0x00230B3C File Offset: 0x0022ED3C
		// (set) Token: 0x060082A0 RID: 33440 RVA: 0x0003DB67 File Offset: 0x0003BD67
		public unsafe AudioSourceController SlurpSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x060082A1 RID: 33441 RVA: 0x00230B6C File Offset: 0x0022ED6C
		// (set) Token: 0x060082A2 RID: 33442 RVA: 0x0003DB86 File Offset: 0x0003BD86
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040058EE RID: 22766
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDrinking_k__BackingField;

		// Token: 0x040058EF RID: 22767
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseEnergyGain;

		// Token: 0x040058F0 RID: 22768
		private static readonly System.IntPtr NativeFieldInfoPtr_MinEnergyGain;

		// Token: 0x040058F1 RID: 22769
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsecutiveReduction;

		// Token: 0x040058F2 RID: 22770
		private static readonly System.IntPtr NativeFieldInfoPtr_HealthGain;

		// Token: 0x040058F3 RID: 22771
		private static readonly System.IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x040058F4 RID: 22772
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearDrugEffects;

		// Token: 0x040058F5 RID: 22773
		private static readonly System.IntPtr NativeFieldInfoPtr_PseudoProduct;

		// Token: 0x040058F6 RID: 22774
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x040058F7 RID: 22775
		private static readonly System.IntPtr NativeFieldInfoPtr_DrinkAnim;

		// Token: 0x040058F8 RID: 22776
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x040058F9 RID: 22777
		private static readonly System.IntPtr NativeFieldInfoPtr_SlurpSound;

		// Token: 0x040058FA RID: 22778
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x040058FB RID: 22779
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0;

		// Token: 0x040058FC RID: 22780
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0;

		// Token: 0x040058FD RID: 22781
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040058FE RID: 22782
		private static readonly System.IntPtr NativeMethodInfoPtr_Drink_Public_Void_0;

		// Token: 0x040058FF RID: 22783
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEffects_Public_Void_0;

		// Token: 0x04005900 RID: 22784
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005901 RID: 22785
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B2C RID: 2860
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_Cuke+<<Drink>g__DrinkRoutine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DA1F RID: 55839 RVA: 0x0034259C File Offset: 0x0034079C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<<Drink>g__DrinkRoutine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679783);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679784);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679785);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679786);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679787);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679788);
			}

			// Token: 0x0600DA20 RID: 55840 RVA: 0x0034267C File Offset: 0x0034087C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA21 RID: 55841 RVA: 0x003426C4 File Offset: 0x003408C4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA22 RID: 55842 RVA: 0x003426F8 File Offset: 0x003408F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248042, XrefRangeEnd = 248088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004349 RID: 17225
			// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x00342734 File Offset: 0x00340934
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA24 RID: 55844 RVA: 0x00342774 File Offset: 0x00340974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248088, XrefRangeEnd = 248093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700434A RID: 17226
			// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x003427A8 File Offset: 0x003409A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA26 RID: 55846 RVA: 0x00069D11 File Offset: 0x00067F11
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004346 RID: 17222
			// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x003427E8 File Offset: 0x003409E8
			// (set) Token: 0x0600DA28 RID: 55848 RVA: 0x00069D1A File Offset: 0x00067F1A
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004347 RID: 17223
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x00342810 File Offset: 0x00340A10
			// (set) Token: 0x0600DA2A RID: 55850 RVA: 0x00069D35 File Offset: 0x00067F35
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004348 RID: 17224
			// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x00342840 File Offset: 0x00340A40
			// (set) Token: 0x0600DA2C RID: 55852 RVA: 0x00069D54 File Offset: 0x00067F54
			public unsafe Equippable_Cuke __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_Cuke>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092CD RID: 37581
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092CE RID: 37582
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092CF RID: 37583
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092D0 RID: 37584
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092D1 RID: 37585
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092D2 RID: 37586
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092D3 RID: 37587
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092D4 RID: 37588
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092D5 RID: 37589
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
