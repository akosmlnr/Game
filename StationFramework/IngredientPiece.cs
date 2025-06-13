using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AC RID: 1452
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x06007ED8 RID: 32472 RVA: 0x00222DAC File Offset: 0x00220FAC
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientPiece()
		{
			Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientPiece");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr);
			IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LIQUID_FRICTION");
			IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<CurrentDissolveAmount>k__BackingField");
			IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "CurrentLiquidContainer");
			IngredientPiece.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "ModelContainer");
			IngredientPiece.NativeFieldInfoPtr_DissolveParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DissolveParticles");
			IngredientPiece.NativeFieldInfoPtr_DetectLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DetectLiquid");
			IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DisableInteractionInLiquid");
			IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LiquidFrictionMultiplier");
			IngredientPiece.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "draggable");
			IngredientPiece.NativeFieldInfoPtr_defaultDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "defaultDrag");
			IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "dissolveParticleRoutine");
			IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679287);
			IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679288);
			IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679289);
			IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679290);
			IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679291);
			IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679292);
			IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679293);
			IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679294);
			IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679295);
			IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100679296);
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x00222F80 File Offset: 0x00221180
		// (set) Token: 0x06007EDA RID: 32474 RVA: 0x00222FBC File Offset: 0x002211BC
		public unsafe float CurrentDissolveAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x00222FFC File Offset: 0x002211FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241346, XrefRangeEnd = 241353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x00223030 File Offset: 0x00221230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241353, XrefRangeEnd = 241357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x00223064 File Offset: 0x00221264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241357, XrefRangeEnd = 241358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x00223098 File Offset: 0x00221298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241378, RefRangeEnd = 241379, XrefRangeStart = 241358, XrefRangeEnd = 241378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x002230CC File Offset: 0x002212CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241379, XrefRangeEnd = 241395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x00223100 File Offset: 0x00221300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241410, RefRangeEnd = 241411, XrefRangeStart = 241395, XrefRangeEnd = 241410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DissolveAmount(float amount, bool showParticles = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref showParticles;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x0022314C File Offset: 0x0022134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241411, XrefRangeEnd = 241412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientPiece() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x00223188 File Offset: 0x00221388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241412, XrefRangeEnd = 241417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x0003BF46 File Offset: 0x0003A146
		public IngredientPiece(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06007EE4 RID: 32484 RVA: 0x002231C8 File Offset: 0x002213C8
		// (set) Token: 0x06007EE5 RID: 32485 RVA: 0x0003BF4F File Offset: 0x0003A14F
		public unsafe static float LIQUID_FRICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&value));
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x002231E4 File Offset: 0x002213E4
		// (set) Token: 0x06007EE7 RID: 32487 RVA: 0x0003BF5D File Offset: 0x0003A15D
		public unsafe float _CurrentDissolveAmount_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007EE8 RID: 32488 RVA: 0x0022320C File Offset: 0x0022140C
		// (set) Token: 0x06007EE9 RID: 32489 RVA: 0x0003BF78 File Offset: 0x0003A178
		public unsafe LiquidContainer CurrentLiquidContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x0022323C File Offset: 0x0022143C
		// (set) Token: 0x06007EEB RID: 32491 RVA: 0x0003BF97 File Offset: 0x0003A197
		public unsafe Transform ModelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x0022326C File Offset: 0x0022146C
		// (set) Token: 0x06007EED RID: 32493 RVA: 0x0003BFB6 File Offset: 0x0003A1B6
		public unsafe ParticleSystem DissolveParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06007EEE RID: 32494 RVA: 0x0022329C File Offset: 0x0022149C
		// (set) Token: 0x06007EEF RID: 32495 RVA: 0x0003BFD5 File Offset: 0x0003A1D5
		public unsafe bool DetectLiquid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid)) = value;
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06007EF0 RID: 32496 RVA: 0x002232C4 File Offset: 0x002214C4
		// (set) Token: 0x06007EF1 RID: 32497 RVA: 0x0003BFF0 File Offset: 0x0003A1F0
		public unsafe bool DisableInteractionInLiquid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid)) = value;
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06007EF2 RID: 32498 RVA: 0x002232EC File Offset: 0x002214EC
		// (set) Token: 0x06007EF3 RID: 32499 RVA: 0x0003C00B File Offset: 0x0003A20B
		public unsafe float LiquidFrictionMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier)) = value;
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06007EF4 RID: 32500 RVA: 0x00223314 File Offset: 0x00221514
		// (set) Token: 0x06007EF5 RID: 32501 RVA: 0x0003C026 File Offset: 0x0003A226
		public unsafe Draggable draggable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x00223344 File Offset: 0x00221544
		// (set) Token: 0x06007EF7 RID: 32503 RVA: 0x0003C045 File Offset: 0x0003A245
		public unsafe float defaultDrag
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag)) = value;
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007EF8 RID: 32504 RVA: 0x0022336C File Offset: 0x0022156C
		// (set) Token: 0x06007EF9 RID: 32505 RVA: 0x0003C060 File Offset: 0x0003A260
		public unsafe Coroutine dissolveParticleRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400565E RID: 22110
		private static readonly System.IntPtr NativeFieldInfoPtr_LIQUID_FRICTION;

		// Token: 0x0400565F RID: 22111
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField;

		// Token: 0x04005660 RID: 22112
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentLiquidContainer;

		// Token: 0x04005661 RID: 22113
		private static readonly System.IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04005662 RID: 22114
		private static readonly System.IntPtr NativeFieldInfoPtr_DissolveParticles;

		// Token: 0x04005663 RID: 22115
		private static readonly System.IntPtr NativeFieldInfoPtr_DetectLiquid;

		// Token: 0x04005664 RID: 22116
		private static readonly System.IntPtr NativeFieldInfoPtr_DisableInteractionInLiquid;

		// Token: 0x04005665 RID: 22117
		private static readonly System.IntPtr NativeFieldInfoPtr_LiquidFrictionMultiplier;

		// Token: 0x04005666 RID: 22118
		private static readonly System.IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04005667 RID: 22119
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultDrag;

		// Token: 0x04005668 RID: 22120
		private static readonly System.IntPtr NativeFieldInfoPtr_dissolveParticleRoutine;

		// Token: 0x04005669 RID: 22121
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0;

		// Token: 0x0400566A RID: 22122
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0;

		// Token: 0x0400566B RID: 22123
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400566C RID: 22124
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400566D RID: 22125
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400566E RID: 22126
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_0;

		// Token: 0x0400566F RID: 22127
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckLiquid_Private_Void_0;

		// Token: 0x04005670 RID: 22128
		private static readonly System.IntPtr NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0;

		// Token: 0x04005671 RID: 22129
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005672 RID: 22130
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B08 RID: 2824
		[ObfuscatedName("ScheduleOne.StationFramework.IngredientPiece+<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D902 RID: 55554 RVA: 0x0033F314 File Offset: 0x0033D514
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679297);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679298);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679299);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679300);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679301);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679302);
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x0033F3F4 File Offset: 0x0033D5F4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x0033F43C File Offset: 0x0033D63C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x0033F470 File Offset: 0x0033D670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241336, XrefRangeEnd = 241341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170042FD RID: 17149
			// (get) Token: 0x0600D906 RID: 55558 RVA: 0x0033F4AC File Offset: 0x0033D6AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D907 RID: 55559 RVA: 0x0033F4EC File Offset: 0x0033D6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241341, XrefRangeEnd = 241346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170042FE RID: 17150
			// (get) Token: 0x0600D908 RID: 55560 RVA: 0x0033F520 File Offset: 0x0033D720
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D909 RID: 55561 RVA: 0x0006951A File Offset: 0x0006771A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FA RID: 17146
			// (get) Token: 0x0600D90A RID: 55562 RVA: 0x0033F560 File Offset: 0x0033D760
			// (set) Token: 0x0600D90B RID: 55563 RVA: 0x00069523 File Offset: 0x00067723
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042FB RID: 17147
			// (get) Token: 0x0600D90C RID: 55564 RVA: 0x0033F588 File Offset: 0x0033D788
			// (set) Token: 0x0600D90D RID: 55565 RVA: 0x0006953E File Offset: 0x0006773E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042FC RID: 17148
			// (get) Token: 0x0600D90E RID: 55566 RVA: 0x0033F5B8 File Offset: 0x0033D7B8
			// (set) Token: 0x0600D90F RID: 55567 RVA: 0x0006955D File Offset: 0x0006775D
			public unsafe IngredientPiece __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientPiece>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009235 RID: 37429
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009236 RID: 37430
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009237 RID: 37431
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009238 RID: 37432
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009239 RID: 37433
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400923A RID: 37434
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400923B RID: 37435
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400923C RID: 37436
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400923D RID: 37437
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
