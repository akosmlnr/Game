using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200067F RID: 1663
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		// Token: 0x06009364 RID: 37732 RVA: 0x00263F18 File Offset: 0x00262118
		// Note: this type is marked as 'beforefieldinit'.
		static PassOutScreen()
		{
			Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PassOutScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr);
			PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "CASH_LOSS_MIN");
			PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "CASH_LOSS_MAX");
			PassOutScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Canvas");
			PassOutScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Group");
			PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "RecoveryPointsContainer");
			PassOutScreen.NativeFieldInfoPtr_MainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "MainLabel");
			PassOutScreen.NativeFieldInfoPtr_ContextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "ContextLabel");
			PassOutScreen.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Anim");
			PassOutScreen.NativeFieldInfoPtr_cashLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "cashLoss");
			PassOutScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681649);
			PassOutScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681650);
			PassOutScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681651);
			PassOutScreen.NativeMethodInfoPtr_Continue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681652);
			PassOutScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681653);
			PassOutScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681654);
			PassOutScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681655);
			PassOutScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681656);
			PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681657);
			PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681658);
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x002640D8 File Offset: 0x002622D8
		// (set) Token: 0x06009366 RID: 37734 RVA: 0x00264114 File Offset: 0x00262314
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00264154 File Offset: 0x00262354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266548, XrefRangeEnd = 266555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassOutScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00264190 File Offset: 0x00262390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266555, XrefRangeEnd = 266561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Continue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x002641C4 File Offset: 0x002623C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266561, XrefRangeEnd = 266562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x002641F8 File Offset: 0x002623F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266585, RefRangeEnd = 266586, XrefRangeStart = 266562, XrefRangeEnd = 266585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x0026422C File Offset: 0x0026242C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266609, RefRangeEnd = 266611, XrefRangeStart = 266586, XrefRangeEnd = 266609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00264260 File Offset: 0x00262460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266611, XrefRangeEnd = 266614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassOutScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x0026429C File Offset: 0x0026249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266614, XrefRangeEnd = 266619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x002642DC File Offset: 0x002624DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266619, XrefRangeEnd = 266624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x00046F4F File Offset: 0x0004514F
		public PassOutScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x06009370 RID: 37744 RVA: 0x0026431C File Offset: 0x0026251C
		// (set) Token: 0x06009371 RID: 37745 RVA: 0x00046F58 File Offset: 0x00045158
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x06009372 RID: 37746 RVA: 0x00264344 File Offset: 0x00262544
		// (set) Token: 0x06009373 RID: 37747 RVA: 0x00046F73 File Offset: 0x00045173
		public unsafe static float CASH_LOSS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x00264360 File Offset: 0x00262560
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x00046F81 File Offset: 0x00045181
		public unsafe static float CASH_LOSS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x06009376 RID: 37750 RVA: 0x0026437C File Offset: 0x0026257C
		// (set) Token: 0x06009377 RID: 37751 RVA: 0x00046F8F File Offset: 0x0004518F
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x002643AC File Offset: 0x002625AC
		// (set) Token: 0x06009379 RID: 37753 RVA: 0x00046FAE File Offset: 0x000451AE
		public unsafe CanvasGroup Group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x002643DC File Offset: 0x002625DC
		// (set) Token: 0x0600937B RID: 37755 RVA: 0x00046FCD File Offset: 0x000451CD
		public unsafe Transform RecoveryPointsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x0026440C File Offset: 0x0026260C
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x00046FEC File Offset: 0x000451EC
		public unsafe TextMeshProUGUI MainLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_MainLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_MainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x0026443C File Offset: 0x0026263C
		// (set) Token: 0x0600937F RID: 37759 RVA: 0x0004700B File Offset: 0x0004520B
		public unsafe TextMeshProUGUI ContextLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_ContextLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_ContextLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x0026446C File Offset: 0x0026266C
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x0004702A File Offset: 0x0004522A
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x0026449C File Offset: 0x0026269C
		// (set) Token: 0x06009383 RID: 37763 RVA: 0x00047049 File Offset: 0x00045249
		public unsafe float cashLoss
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_cashLoss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_cashLoss)) = value;
			}
		}

		// Token: 0x040063A9 RID: 25513
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040063AA RID: 25514
		private static readonly System.IntPtr NativeFieldInfoPtr_CASH_LOSS_MIN;

		// Token: 0x040063AB RID: 25515
		private static readonly System.IntPtr NativeFieldInfoPtr_CASH_LOSS_MAX;

		// Token: 0x040063AC RID: 25516
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040063AD RID: 25517
		private static readonly System.IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x040063AE RID: 25518
		private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryPointsContainer;

		// Token: 0x040063AF RID: 25519
		private static readonly System.IntPtr NativeFieldInfoPtr_MainLabel;

		// Token: 0x040063B0 RID: 25520
		private static readonly System.IntPtr NativeFieldInfoPtr_ContextLabel;

		// Token: 0x040063B1 RID: 25521
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040063B2 RID: 25522
		private static readonly System.IntPtr NativeFieldInfoPtr_cashLoss;

		// Token: 0x040063B3 RID: 25523
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040063B4 RID: 25524
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040063B5 RID: 25525
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063B6 RID: 25526
		private static readonly System.IntPtr NativeMethodInfoPtr_Continue_Private_Void_0;

		// Token: 0x040063B7 RID: 25527
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0;

		// Token: 0x040063B8 RID: 25528
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040063B9 RID: 25529
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040063BA RID: 25530
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063BB RID: 25531
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040063BC RID: 25532
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B8F RID: 2959
		[ObfuscatedName("ScheduleOne.UI.PassOutScreen+<<Continue>g__Routine|14_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DDEF RID: 56815 RVA: 0x0034D42C File Offset: 0x0034B62C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique()
			{
				Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<<Continue>g__Routine|14_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>1__state");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>2__current");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>4__this");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<fadeTime>5__2");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<fadeBlur>5__3");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<lerpTime>5__4");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<i>5__5");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681659);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681660);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681661);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681662);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681663);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681664);
			}

			// Token: 0x0600DDF0 RID: 56816 RVA: 0x0034D55C File Offset: 0x0034B75C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DDF1 RID: 56817 RVA: 0x0034D5A4 File Offset: 0x0034B7A4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DDF2 RID: 56818 RVA: 0x0034D5D8 File Offset: 0x0034B7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266402, XrefRangeEnd = 266528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700448E RID: 17550
			// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0034D614 File Offset: 0x0034B814
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DDF4 RID: 56820 RVA: 0x0034D654 File Offset: 0x0034B854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266528, XrefRangeEnd = 266533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700448F RID: 17551
			// (get) Token: 0x0600DDF5 RID: 56821 RVA: 0x0034D688 File Offset: 0x0034B888
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DDF6 RID: 56822 RVA: 0x0006BC50 File Offset: 0x00069E50
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004487 RID: 17543
			// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x0034D6C8 File Offset: 0x0034B8C8
			// (set) Token: 0x0600DDF8 RID: 56824 RVA: 0x0006BC59 File Offset: 0x00069E59
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004488 RID: 17544
			// (get) Token: 0x0600DDF9 RID: 56825 RVA: 0x0034D6F0 File Offset: 0x0034B8F0
			// (set) Token: 0x0600DDFA RID: 56826 RVA: 0x0006BC74 File Offset: 0x00069E74
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004489 RID: 17545
			// (get) Token: 0x0600DDFB RID: 56827 RVA: 0x0034D720 File Offset: 0x0034B920
			// (set) Token: 0x0600DDFC RID: 56828 RVA: 0x0006BC93 File Offset: 0x00069E93
			public unsafe PassOutScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassOutScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700448A RID: 17546
			// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x0034D750 File Offset: 0x0034B950
			// (set) Token: 0x0600DDFE RID: 56830 RVA: 0x0006BCB2 File Offset: 0x00069EB2
			public unsafe float _fadeTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2)) = value;
				}
			}

			// Token: 0x1700448B RID: 17547
			// (get) Token: 0x0600DDFF RID: 56831 RVA: 0x0034D778 File Offset: 0x0034B978
			// (set) Token: 0x0600DE00 RID: 56832 RVA: 0x0006BCCD File Offset: 0x00069ECD
			public unsafe bool _fadeBlur_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3)) = value;
				}
			}

			// Token: 0x1700448C RID: 17548
			// (get) Token: 0x0600DE01 RID: 56833 RVA: 0x0034D7A0 File Offset: 0x0034B9A0
			// (set) Token: 0x0600DE02 RID: 56834 RVA: 0x0006BCE8 File Offset: 0x00069EE8
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x1700448D RID: 17549
			// (get) Token: 0x0600DE03 RID: 56835 RVA: 0x0034D7C8 File Offset: 0x0034B9C8
			// (set) Token: 0x0600DE04 RID: 56836 RVA: 0x0006BD03 File Offset: 0x00069F03
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009535 RID: 38197
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009536 RID: 38198
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009537 RID: 38199
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009538 RID: 38200
			private static readonly System.IntPtr NativeFieldInfoPtr__fadeTime_5__2;

			// Token: 0x04009539 RID: 38201
			private static readonly System.IntPtr NativeFieldInfoPtr__fadeBlur_5__3;

			// Token: 0x0400953A RID: 38202
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x0400953B RID: 38203
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400953C RID: 38204
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400953D RID: 38205
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400953E RID: 38206
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400953F RID: 38207
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009540 RID: 38208
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009541 RID: 38209
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B90 RID: 2960
		[ObfuscatedName("ScheduleOne.UI.PassOutScreen+<<Open>g__Routine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE05 RID: 56837 RVA: 0x0034D7F0 File Offset: 0x0034B9F0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique()
			{
				Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<<Open>g__Routine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>1__state");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>2__current");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>4__this");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<lerpTime>5__2");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<startOpenness>5__3");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<endOpenness>5__4");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<i>5__5");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681665);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681666);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681667);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681668);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681669);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681670);
			}

			// Token: 0x0600DE06 RID: 56838 RVA: 0x0034D920 File Offset: 0x0034BB20
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE07 RID: 56839 RVA: 0x0034D968 File Offset: 0x0034BB68
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE08 RID: 56840 RVA: 0x0034D99C File Offset: 0x0034BB9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266533, XrefRangeEnd = 266543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004497 RID: 17559
			// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x0034D9D8 File Offset: 0x0034BBD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DE0A RID: 56842 RVA: 0x0034DA18 File Offset: 0x0034BC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266543, XrefRangeEnd = 266548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004498 RID: 17560
			// (get) Token: 0x0600DE0B RID: 56843 RVA: 0x0034DA4C File Offset: 0x0034BC4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DE0C RID: 56844 RVA: 0x0006BD1E File Offset: 0x00069F1E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004490 RID: 17552
			// (get) Token: 0x0600DE0D RID: 56845 RVA: 0x0034DA8C File Offset: 0x0034BC8C
			// (set) Token: 0x0600DE0E RID: 56846 RVA: 0x0006BD27 File Offset: 0x00069F27
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004491 RID: 17553
			// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x0034DAB4 File Offset: 0x0034BCB4
			// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x0006BD42 File Offset: 0x00069F42
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004492 RID: 17554
			// (get) Token: 0x0600DE11 RID: 56849 RVA: 0x0034DAE4 File Offset: 0x0034BCE4
			// (set) Token: 0x0600DE12 RID: 56850 RVA: 0x0006BD61 File Offset: 0x00069F61
			public unsafe PassOutScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassOutScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004493 RID: 17555
			// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x0034DB14 File Offset: 0x0034BD14
			// (set) Token: 0x0600DE14 RID: 56852 RVA: 0x0006BD80 File Offset: 0x00069F80
			public unsafe float _lerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004494 RID: 17556
			// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x0034DB3C File Offset: 0x0034BD3C
			// (set) Token: 0x0600DE16 RID: 56854 RVA: 0x0006BD9B File Offset: 0x00069F9B
			public unsafe float _startOpenness_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3)) = value;
				}
			}

			// Token: 0x17004495 RID: 17557
			// (get) Token: 0x0600DE17 RID: 56855 RVA: 0x0034DB64 File Offset: 0x0034BD64
			// (set) Token: 0x0600DE18 RID: 56856 RVA: 0x0006BDB6 File Offset: 0x00069FB6
			public unsafe float _endOpenness_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4)) = value;
				}
			}

			// Token: 0x17004496 RID: 17558
			// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x0034DB8C File Offset: 0x0034BD8C
			// (set) Token: 0x0600DE1A RID: 56858 RVA: 0x0006BDD1 File Offset: 0x00069FD1
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009542 RID: 38210
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009543 RID: 38211
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009544 RID: 38212
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009545 RID: 38213
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04009546 RID: 38214
			private static readonly System.IntPtr NativeFieldInfoPtr__startOpenness_5__3;

			// Token: 0x04009547 RID: 38215
			private static readonly System.IntPtr NativeFieldInfoPtr__endOpenness_5__4;

			// Token: 0x04009548 RID: 38216
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04009549 RID: 38217
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400954A RID: 38218
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400954B RID: 38219
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400954C RID: 38220
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400954D RID: 38221
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400954E RID: 38222
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
