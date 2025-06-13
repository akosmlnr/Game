using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppLiquidVolumeFX;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AE RID: 1454
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x06007F06 RID: 32518 RVA: 0x00223650 File Offset: 0x00221850
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidContainer()
		{
			Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr);
			LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<CurrentLiquidLevel>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<LiquidColor>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr_Viscosity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Viscosity");
			LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "AdjustMurkiness");
			LiquidContainer.NativeFieldInfoPtr_LiquidVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "LiquidVolume");
			LiquidContainer.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Collider");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Min");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Max");
			LiquidContainer.NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "MaxLevel");
			LiquidContainer.NativeFieldInfoPtr_liquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "liquidMesh");
			LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679309);
			LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679310);
			LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679311);
			LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679312);
			LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679313);
			LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679314);
			LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679315);
			LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679316);
			LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679317);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679318);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679319);
			LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100679320);
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06007F07 RID: 32519 RVA: 0x00223838 File Offset: 0x00221A38
		// (set) Token: 0x06007F08 RID: 32520 RVA: 0x00223874 File Offset: 0x00221A74
		public unsafe float CurrentLiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x002238B4 File Offset: 0x00221AB4
		// (set) Token: 0x06007F0A RID: 32522 RVA: 0x002238F0 File Offset: 0x00221AF0
		public unsafe Color LiquidColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x00223930 File Offset: 0x00221B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241418, XrefRangeEnd = 241425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x00223964 File Offset: 0x00221B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241425, XrefRangeEnd = 241448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x00223998 File Offset: 0x00221B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241448, XrefRangeEnd = 241466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x002239CC File Offset: 0x00221BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241466, XrefRangeEnd = 241467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x00223A00 File Offset: 0x00221C00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241473, RefRangeEnd = 241477, XrefRangeStart = 241467, XrefRangeEnd = 241473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLighting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x00223A34 File Offset: 0x00221C34
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 241512, RefRangeEnd = 241520, XrefRangeStart = 241477, XrefRangeEnd = 241512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidLevel(float level, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x00223A80 File Offset: 0x00221C80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241523, RefRangeEnd = 241526, XrefRangeStart = 241520, XrefRangeEnd = 241523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setColorVariable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLigting;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x00223ADC File Offset: 0x00221CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241526, XrefRangeEnd = 241527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x0003C0C2 File Offset: 0x0003A2C2
		public LiquidContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06007F14 RID: 32532 RVA: 0x00223B18 File Offset: 0x00221D18
		// (set) Token: 0x06007F15 RID: 32533 RVA: 0x0003C0CB File Offset: 0x0003A2CB
		public unsafe float _CurrentLiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06007F16 RID: 32534 RVA: 0x00223B40 File Offset: 0x00221D40
		// (set) Token: 0x06007F17 RID: 32535 RVA: 0x0003C0E6 File Offset: 0x0003A2E6
		public unsafe Color _LiquidColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06007F18 RID: 32536 RVA: 0x00223B68 File Offset: 0x00221D68
		// (set) Token: 0x06007F19 RID: 32537 RVA: 0x0003C101 File Offset: 0x0003A301
		public unsafe float Viscosity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity)) = value;
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x00223B90 File Offset: 0x00221D90
		// (set) Token: 0x06007F1B RID: 32539 RVA: 0x0003C11C File Offset: 0x0003A31C
		public unsafe bool AdjustMurkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness)) = value;
			}
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06007F1C RID: 32540 RVA: 0x00223BB8 File Offset: 0x00221DB8
		// (set) Token: 0x06007F1D RID: 32541 RVA: 0x0003C137 File Offset: 0x0003A337
		public unsafe LiquidVolume LiquidVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06007F1E RID: 32542 RVA: 0x00223BE8 File Offset: 0x00221DE8
		// (set) Token: 0x06007F1F RID: 32543 RVA: 0x0003C156 File Offset: 0x0003A356
		public unsafe LiquidVolumeCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x00223C18 File Offset: 0x00221E18
		// (set) Token: 0x06007F21 RID: 32545 RVA: 0x0003C175 File Offset: 0x0003A375
		public unsafe Transform ColliderTransform_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x00223C48 File Offset: 0x00221E48
		// (set) Token: 0x06007F23 RID: 32547 RVA: 0x0003C194 File Offset: 0x0003A394
		public unsafe Transform ColliderTransform_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06007F24 RID: 32548 RVA: 0x00223C78 File Offset: 0x00221E78
		// (set) Token: 0x06007F25 RID: 32549 RVA: 0x0003C1B3 File Offset: 0x0003A3B3
		public unsafe float MaxLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel)) = value;
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06007F26 RID: 32550 RVA: 0x00223CA0 File Offset: 0x00221EA0
		// (set) Token: 0x06007F27 RID: 32551 RVA: 0x0003C1CE File Offset: 0x0003A3CE
		public unsafe MeshRenderer liquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400567B RID: 22139
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField;

		// Token: 0x0400567C RID: 22140
		private static readonly IntPtr NativeFieldInfoPtr__LiquidColor_k__BackingField;

		// Token: 0x0400567D RID: 22141
		private static readonly IntPtr NativeFieldInfoPtr_Viscosity;

		// Token: 0x0400567E RID: 22142
		private static readonly IntPtr NativeFieldInfoPtr_AdjustMurkiness;

		// Token: 0x0400567F RID: 22143
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolume;

		// Token: 0x04005680 RID: 22144
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005681 RID: 22145
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Min;

		// Token: 0x04005682 RID: 22146
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Max;

		// Token: 0x04005683 RID: 22147
		private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

		// Token: 0x04005684 RID: 22148
		private static readonly IntPtr NativeFieldInfoPtr_liquidMesh;

		// Token: 0x04005685 RID: 22149
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0;

		// Token: 0x04005686 RID: 22150
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0;

		// Token: 0x04005687 RID: 22151
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0;

		// Token: 0x04005688 RID: 22152
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0;

		// Token: 0x04005689 RID: 22153
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400568A RID: 22154
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400568B RID: 22155
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400568C RID: 22156
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400568D RID: 22157
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLighting_Private_Void_0;

		// Token: 0x0400568E RID: 22158
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0;

		// Token: 0x0400568F RID: 22159
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0;

		// Token: 0x04005690 RID: 22160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
