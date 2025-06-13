using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x0200069B RID: 1691
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x0600960A RID: 38410 RVA: 0x0026BBE4 File Offset: 0x00269DE4
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupCanvas()
		{
			Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr);
			WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WORLDSPACE_ICON_SCALE_MULTIPLIER");
			WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WorldspaceContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudIconContainerPrefab");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeWorldspaceUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeHUDUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "popupsWithUI");
			WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681992);
			WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681993);
			WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681994);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681995);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681996);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681997);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681998);
			WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681999);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0026BD40 File Offset: 0x00269F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269641, XrefRangeEnd = 269753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x0026BD74 File Offset: 0x00269F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269753, XrefRangeEnd = 269850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x0026BDA8 File Offset: 0x00269FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269863, RefRangeEnd = 269865, XrefRangeStart = 269850, XrefRangeEnd = 269863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldCreateUI(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x0026BDF8 File Offset: 0x00269FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269865, XrefRangeEnd = 269877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x0026BE48 File Offset: 0x0026A048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269905, RefRangeEnd = 269906, XrefRangeStart = 269877, XrefRangeEnd = 269905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x0026BE98 File Offset: 0x0026A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269906, XrefRangeEnd = 269924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x0026BEDC File Offset: 0x0026A0DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269950, RefRangeEnd = 269951, XrefRangeStart = 269924, XrefRangeEnd = 269950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x0026BF20 File Offset: 0x0026A120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269951, XrefRangeEnd = 269973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009613 RID: 38419 RVA: 0x000487A2 File Offset: 0x000469A2
		public WorldspacePopupCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x06009614 RID: 38420 RVA: 0x0026BF5C File Offset: 0x0026A15C
		// (set) Token: 0x06009615 RID: 38421 RVA: 0x000487AB File Offset: 0x000469AB
		public unsafe static float WORLDSPACE_ICON_SCALE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x06009616 RID: 38422 RVA: 0x0026BF78 File Offset: 0x0026A178
		// (set) Token: 0x06009617 RID: 38423 RVA: 0x000487B9 File Offset: 0x000469B9
		public unsafe RectTransform WorldspaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x06009618 RID: 38424 RVA: 0x0026BFA8 File Offset: 0x0026A1A8
		// (set) Token: 0x06009619 RID: 38425 RVA: 0x000487D8 File Offset: 0x000469D8
		public unsafe RectTransform HudContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600961A RID: 38426 RVA: 0x0026BFD8 File Offset: 0x0026A1D8
		// (set) Token: 0x0600961B RID: 38427 RVA: 0x000487F7 File Offset: 0x000469F7
		public unsafe GameObject HudIconContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600961C RID: 38428 RVA: 0x0026C008 File Offset: 0x0026A208
		// (set) Token: 0x0600961D RID: 38429 RVA: 0x00048816 File Offset: 0x00046A16
		public unsafe List<WorldspacePopupUI> activeWorldspaceUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600961E RID: 38430 RVA: 0x0026C038 File Offset: 0x0026A238
		// (set) Token: 0x0600961F RID: 38431 RVA: 0x00048835 File Offset: 0x00046A35
		public unsafe List<RectTransform> activeHUDUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x0026C068 File Offset: 0x0026A268
		// (set) Token: 0x06009621 RID: 38433 RVA: 0x00048854 File Offset: 0x00046A54
		public unsafe List<WorldspacePopup> popupsWithUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400654B RID: 25931
		private static readonly IntPtr NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER;

		// Token: 0x0400654C RID: 25932
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceContainer;

		// Token: 0x0400654D RID: 25933
		private static readonly IntPtr NativeFieldInfoPtr_HudContainer;

		// Token: 0x0400654E RID: 25934
		private static readonly IntPtr NativeFieldInfoPtr_HudIconContainerPrefab;

		// Token: 0x0400654F RID: 25935
		private static readonly IntPtr NativeFieldInfoPtr_activeWorldspaceUIs;

		// Token: 0x04006550 RID: 25936
		private static readonly IntPtr NativeFieldInfoPtr_activeHUDUIs;

		// Token: 0x04006551 RID: 25937
		private static readonly IntPtr NativeFieldInfoPtr_popupsWithUI;

		// Token: 0x04006552 RID: 25938
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006553 RID: 25939
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006554 RID: 25940
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0;

		// Token: 0x04006555 RID: 25941
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0;

		// Token: 0x04006556 RID: 25942
		private static readonly IntPtr NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0;

		// Token: 0x04006557 RID: 25943
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x04006558 RID: 25944
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x04006559 RID: 25945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
