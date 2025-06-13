using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x0200069C RID: 1692
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x06009622 RID: 38434 RVA: 0x0026C098 File Offset: 0x0026A298
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupUI()
		{
			Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr);
			WorldspacePopupUI.NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Popup");
			WorldspacePopupUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Rect");
			WorldspacePopupUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "FillImage");
			WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "onDestroyed");
			WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100682000);
			WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100682001);
			WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100682002);
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x0026C154 File Offset: 0x0026A354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269973, XrefRangeEnd = 269975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFill(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x0026C194 File Offset: 0x0026A394
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269981, RefRangeEnd = 269984, XrefRangeStart = 269975, XrefRangeEnd = 269981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x0026C1C8 File Offset: 0x0026A3C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x00048873 File Offset: 0x00046A73
		public WorldspacePopupUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x06009627 RID: 38439 RVA: 0x0026C204 File Offset: 0x0026A404
		// (set) Token: 0x06009628 RID: 38440 RVA: 0x0004887C File Offset: 0x00046A7C
		public unsafe WorldspacePopup Popup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x0026C234 File Offset: 0x0026A434
		// (set) Token: 0x0600962A RID: 38442 RVA: 0x0004889B File Offset: 0x00046A9B
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600962B RID: 38443 RVA: 0x0026C264 File Offset: 0x0026A464
		// (set) Token: 0x0600962C RID: 38444 RVA: 0x000488BA File Offset: 0x00046ABA
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600962D RID: 38445 RVA: 0x0026C294 File Offset: 0x0026A494
		// (set) Token: 0x0600962E RID: 38446 RVA: 0x000488D9 File Offset: 0x00046AD9
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400655A RID: 25946
		private static readonly IntPtr NativeFieldInfoPtr_Popup;

		// Token: 0x0400655B RID: 25947
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x0400655C RID: 25948
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x0400655D RID: 25949
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x0400655E RID: 25950
		private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_0;

		// Token: 0x0400655F RID: 25951
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04006560 RID: 25952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
