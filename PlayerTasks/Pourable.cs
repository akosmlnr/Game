using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020F RID: 527
	public class Pourable : Draggable
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x000FBDBC File Offset: 0x000F9FBC
		// Note: this type is marked as 'beforefieldinit'.
		static Pourable()
		{
			Il2CppClassPointerStore<Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pourable>.NativeClassPtr);
			Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<IsPouring>k__BackingField");
			Pourable.NativeFieldInfoPtr_onInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "onInitialPour");
			Pourable.NativeFieldInfoPtr_Unlimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "Unlimited");
			Pourable.NativeFieldInfoPtr_StartQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "StartQuantity");
			Pourable.NativeFieldInfoPtr_PourRate_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourRate_L");
			Pourable.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AngleFromUpToPour");
			Pourable.NativeFieldInfoPtr_ShakeBoostRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ShakeBoostRate");
			Pourable.NativeFieldInfoPtr_AffectsCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AffectsCoverage");
			Pourable.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMinMultiplier");
			Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMaxMultiplier");
			Pourable.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourParticles");
			Pourable.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourPoint");
			Pourable.NativeFieldInfoPtr_PourLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourLoop");
			Pourable.NativeFieldInfoPtr_TrashItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TrashItem");
			Pourable.NativeFieldInfoPtr_TargetPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TargetPot");
			Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			Pourable.NativeFieldInfoPtr_currentQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "currentQuantity");
			Pourable.NativeFieldInfoPtr_hasPoured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "hasPoured");
			Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "autoSetCurrentQuantity");
			Pourable.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMinSizes");
			Pourable.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMaxSizes");
			Pourable.NativeFieldInfoPtr_accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "accelerometer");
			Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668186);
			Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668187);
			Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668188);
			Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668189);
			Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668190);
			Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668191);
			Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668192);
			Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668193);
			Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668194);
			Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668195);
			Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668196);
			Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668197);
			Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668198);
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000FC0A8 File Offset: 0x000FA2A8
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x000FC0E4 File Offset: 0x000FA2E4
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000FC124 File Offset: 0x000FA324
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x000FC160 File Offset: 0x000FA360
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000FC1A0 File Offset: 0x000FA3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124152, XrefRangeEnd = 124179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000FC1DC File Offset: 0x000FA3DC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000FC218 File Offset: 0x000FA418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124179, XrefRangeEnd = 124180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000FC254 File Offset: 0x000FA454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124180, XrefRangeEnd = 124211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000FC290 File Offset: 0x000FA490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124211, XrefRangeEnd = 124212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShakeBoost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000FC2CC File Offset: 0x000FA4CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124226, RefRangeEnd = 124229, XrefRangeStart = 124212, XrefRangeEnd = 124226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000FC318 File Offset: 0x000FA518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124239, RefRangeEnd = 124240, XrefRangeStart = 124229, XrefRangeEnd = 124239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPourPointOverPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000FC354 File Offset: 0x000FA554
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000FC39C File Offset: 0x000FA59C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124245, RefRangeEnd = 124248, XrefRangeStart = 124240, XrefRangeEnd = 124245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pourable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0001732F File Offset: 0x0001552F
		public Pourable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000FC3D8 File Offset: 0x000FA5D8
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x00017338 File Offset: 0x00015538
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000FC400 File Offset: 0x000FA600
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x00017353 File Offset: 0x00015553
		public unsafe Il2CppSystem.Action onInitialPour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000FC430 File Offset: 0x000FA630
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x00017372 File Offset: 0x00015572
		public unsafe bool Unlimited
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited)) = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000FC458 File Offset: 0x000FA658
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0001738D File Offset: 0x0001558D
		public unsafe float StartQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity)) = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000FC480 File Offset: 0x000FA680
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000173A8 File Offset: 0x000155A8
		public unsafe float PourRate_L
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L)) = value;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000FC4A8 File Offset: 0x000FA6A8
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000173C3 File Offset: 0x000155C3
		public unsafe float AngleFromUpToPour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000FC4D0 File Offset: 0x000FA6D0
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000173DE File Offset: 0x000155DE
		public unsafe float ShakeBoostRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate)) = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000FC4F8 File Offset: 0x000FA6F8
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000173F9 File Offset: 0x000155F9
		public unsafe bool AffectsCoverage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage)) = value;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000FC520 File Offset: 0x000FA720
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00017414 File Offset: 0x00015614
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000FC548 File Offset: 0x000FA748
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x0001742F File Offset: 0x0001562F
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000FC570 File Offset: 0x000FA770
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x0001744A File Offset: 0x0001564A
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000FC5A0 File Offset: 0x000FA7A0
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x00017469 File Offset: 0x00015669
		public unsafe Transform PourPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000FC5D0 File Offset: 0x000FA7D0
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x00017488 File Offset: 0x00015688
		public unsafe AudioSourceController PourLoop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000FC600 File Offset: 0x000FA800
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x000174A7 File Offset: 0x000156A7
		public unsafe TrashItem TrashItem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000FC630 File Offset: 0x000FA830
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000174C6 File Offset: 0x000156C6
		public unsafe Pot TargetPot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetPot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetPot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000FC660 File Offset: 0x000FA860
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x000174E5 File Offset: 0x000156E5
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000FC688 File Offset: 0x000FA888
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x00017500 File Offset: 0x00015700
		public unsafe float currentQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_currentQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_currentQuantity)) = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000FC6B0 File Offset: 0x000FA8B0
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x0001751B File Offset: 0x0001571B
		public unsafe bool hasPoured
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured)) = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000FC6D8 File Offset: 0x000FA8D8
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x00017536 File Offset: 0x00015736
		public unsafe bool autoSetCurrentQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity)) = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000FC700 File Offset: 0x000FA900
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x00017551 File Offset: 0x00015751
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000FC730 File Offset: 0x000FA930
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x00017570 File Offset: 0x00015770
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000FC760 File Offset: 0x000FA960
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0001758F File Offset: 0x0001578F
		public unsafe AverageAcceleration accelerometer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C93 RID: 7315
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x04001C94 RID: 7316
		private static readonly System.IntPtr NativeFieldInfoPtr_onInitialPour;

		// Token: 0x04001C95 RID: 7317
		private static readonly System.IntPtr NativeFieldInfoPtr_Unlimited;

		// Token: 0x04001C96 RID: 7318
		private static readonly System.IntPtr NativeFieldInfoPtr_StartQuantity;

		// Token: 0x04001C97 RID: 7319
		private static readonly System.IntPtr NativeFieldInfoPtr_PourRate_L;

		// Token: 0x04001C98 RID: 7320
		private static readonly System.IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x04001C99 RID: 7321
		private static readonly System.IntPtr NativeFieldInfoPtr_ShakeBoostRate;

		// Token: 0x04001C9A RID: 7322
		private static readonly System.IntPtr NativeFieldInfoPtr_AffectsCoverage;

		// Token: 0x04001C9B RID: 7323
		private static readonly System.IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x04001C9C RID: 7324
		private static readonly System.IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x04001C9D RID: 7325
		private static readonly System.IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04001C9E RID: 7326
		private static readonly System.IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x04001C9F RID: 7327
		private static readonly System.IntPtr NativeFieldInfoPtr_PourLoop;

		// Token: 0x04001CA0 RID: 7328
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashItem;

		// Token: 0x04001CA1 RID: 7329
		private static readonly System.IntPtr NativeFieldInfoPtr_TargetPot;

		// Token: 0x04001CA2 RID: 7330
		private static readonly System.IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x04001CA3 RID: 7331
		private static readonly System.IntPtr NativeFieldInfoPtr_currentQuantity;

		// Token: 0x04001CA4 RID: 7332
		private static readonly System.IntPtr NativeFieldInfoPtr_hasPoured;

		// Token: 0x04001CA5 RID: 7333
		private static readonly System.IntPtr NativeFieldInfoPtr_autoSetCurrentQuantity;

		// Token: 0x04001CA6 RID: 7334
		private static readonly System.IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x04001CA7 RID: 7335
		private static readonly System.IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x04001CA8 RID: 7336
		private static readonly System.IntPtr NativeFieldInfoPtr_accelerometer;

		// Token: 0x04001CA9 RID: 7337
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly System.IntPtr NativeMethodInfoPtr_GetShakeBoost_Private_Single_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly System.IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
