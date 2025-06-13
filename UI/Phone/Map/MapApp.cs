using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Map
{
	// Token: 0x020006CE RID: 1742
	public class MapApp : App<MapApp>
	{
		// Token: 0x06009B25 RID: 39717 RVA: 0x0027B57C File Offset: 0x0027977C
		// Note: this type is marked as 'beforefieldinit'.
		static MapApp()
		{
			Il2CppClassPointerStore<MapApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Map", "MapApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapApp>.NativeClassPtr);
			MapApp.NativeFieldInfoPtr_KeyMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "KeyMoveSpeed");
			MapApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "ContentRect");
			MapApp.NativeFieldInfoPtr_PoIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "PoIContainer");
			MapApp.NativeFieldInfoPtr_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "HorizontalScrollbar");
			MapApp.NativeFieldInfoPtr_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "VerticalScrollbar");
			MapApp.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "BackgroundImage");
			MapApp.NativeFieldInfoPtr_LabelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelGroup");
			MapApp.NativeFieldInfoPtr_DemoMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "DemoMapSprite");
			MapApp.NativeFieldInfoPtr_MainMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "MainMapSprite");
			MapApp.NativeFieldInfoPtr_TutorialMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "TutorialMapSprite");
			MapApp.NativeFieldInfoPtr_LabelScrollMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMin");
			MapApp.NativeFieldInfoPtr_LabelScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMax");
			MapApp.NativeFieldInfoPtr_SkipFocusPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "SkipFocusPlayer");
			MapApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "contentMoveRoutine");
			MapApp.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "opened");
			MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682552);
			MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682553);
			MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682554);
			MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682555);
			MapApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682556);
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x0027B73C File Offset: 0x0027993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277037, XrefRangeEnd = 277047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B27 RID: 39719 RVA: 0x0027B778 File Offset: 0x00279978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277047, XrefRangeEnd = 277091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x0027B7C4 File Offset: 0x002799C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277091, XrefRangeEnd = 277104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0027B800 File Offset: 0x00279A00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277110, RefRangeEnd = 277114, XrefRangeStart = 277104, XrefRangeEnd = 277110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusPosition(Vector2 anchoredPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchoredPosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x0027B840 File Offset: 0x00279A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277114, XrefRangeEnd = 277120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapApp>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x0004B571 File Offset: 0x00049771
		public MapApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x0027B87C File Offset: 0x00279A7C
		// (set) Token: 0x06009B2D RID: 39725 RVA: 0x0004B57A File Offset: 0x0004977A
		public unsafe static float KeyMoveSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009B2E RID: 39726 RVA: 0x0027B898 File Offset: 0x00279A98
		// (set) Token: 0x06009B2F RID: 39727 RVA: 0x0004B588 File Offset: 0x00049788
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x0027B8C8 File Offset: 0x00279AC8
		// (set) Token: 0x06009B31 RID: 39729 RVA: 0x0004B5A7 File Offset: 0x000497A7
		public unsafe RectTransform PoIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x0027B8F8 File Offset: 0x00279AF8
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x0004B5C6 File Offset: 0x000497C6
		public unsafe Scrollbar HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009B34 RID: 39732 RVA: 0x0027B928 File Offset: 0x00279B28
		// (set) Token: 0x06009B35 RID: 39733 RVA: 0x0004B5E5 File Offset: 0x000497E5
		public unsafe Scrollbar VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009B36 RID: 39734 RVA: 0x0027B958 File Offset: 0x00279B58
		// (set) Token: 0x06009B37 RID: 39735 RVA: 0x0004B604 File Offset: 0x00049804
		public unsafe Image BackgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06009B38 RID: 39736 RVA: 0x0027B988 File Offset: 0x00279B88
		// (set) Token: 0x06009B39 RID: 39737 RVA: 0x0004B623 File Offset: 0x00049823
		public unsafe CanvasGroup LabelGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x06009B3A RID: 39738 RVA: 0x0027B9B8 File Offset: 0x00279BB8
		// (set) Token: 0x06009B3B RID: 39739 RVA: 0x0004B642 File Offset: 0x00049842
		public unsafe Sprite DemoMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x06009B3C RID: 39740 RVA: 0x0027B9E8 File Offset: 0x00279BE8
		// (set) Token: 0x06009B3D RID: 39741 RVA: 0x0004B661 File Offset: 0x00049861
		public unsafe Sprite MainMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x0027BA18 File Offset: 0x00279C18
		// (set) Token: 0x06009B3F RID: 39743 RVA: 0x0004B680 File Offset: 0x00049880
		public unsafe Sprite TutorialMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x06009B40 RID: 39744 RVA: 0x0027BA48 File Offset: 0x00279C48
		// (set) Token: 0x06009B41 RID: 39745 RVA: 0x0004B69F File Offset: 0x0004989F
		public unsafe float LabelScrollMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin)) = value;
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x06009B42 RID: 39746 RVA: 0x0027BA70 File Offset: 0x00279C70
		// (set) Token: 0x06009B43 RID: 39747 RVA: 0x0004B6BA File Offset: 0x000498BA
		public unsafe float LabelScrollMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax)) = value;
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x06009B44 RID: 39748 RVA: 0x0027BA98 File Offset: 0x00279C98
		// (set) Token: 0x06009B45 RID: 39749 RVA: 0x0004B6D5 File Offset: 0x000498D5
		public unsafe bool SkipFocusPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer)) = value;
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06009B46 RID: 39750 RVA: 0x0027BAC0 File Offset: 0x00279CC0
		// (set) Token: 0x06009B47 RID: 39751 RVA: 0x0004B6F0 File Offset: 0x000498F0
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06009B48 RID: 39752 RVA: 0x0027BAF0 File Offset: 0x00279CF0
		// (set) Token: 0x06009B49 RID: 39753 RVA: 0x0004B70F File Offset: 0x0004990F
		public unsafe bool opened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened)) = value;
			}
		}

		// Token: 0x04006880 RID: 26752
		private static readonly IntPtr NativeFieldInfoPtr_KeyMoveSpeed;

		// Token: 0x04006881 RID: 26753
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x04006882 RID: 26754
		private static readonly IntPtr NativeFieldInfoPtr_PoIContainer;

		// Token: 0x04006883 RID: 26755
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalScrollbar;

		// Token: 0x04006884 RID: 26756
		private static readonly IntPtr NativeFieldInfoPtr_VerticalScrollbar;

		// Token: 0x04006885 RID: 26757
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;

		// Token: 0x04006886 RID: 26758
		private static readonly IntPtr NativeFieldInfoPtr_LabelGroup;

		// Token: 0x04006887 RID: 26759
		private static readonly IntPtr NativeFieldInfoPtr_DemoMapSprite;

		// Token: 0x04006888 RID: 26760
		private static readonly IntPtr NativeFieldInfoPtr_MainMapSprite;

		// Token: 0x04006889 RID: 26761
		private static readonly IntPtr NativeFieldInfoPtr_TutorialMapSprite;

		// Token: 0x0400688A RID: 26762
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMin;

		// Token: 0x0400688B RID: 26763
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMax;

		// Token: 0x0400688C RID: 26764
		private static readonly IntPtr NativeFieldInfoPtr_SkipFocusPlayer;

		// Token: 0x0400688D RID: 26765
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x0400688E RID: 26766
		private static readonly IntPtr NativeFieldInfoPtr_opened;

		// Token: 0x0400688F RID: 26767
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006890 RID: 26768
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006891 RID: 26769
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006892 RID: 26770
		private static readonly IntPtr NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0;

		// Token: 0x04006893 RID: 26771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
