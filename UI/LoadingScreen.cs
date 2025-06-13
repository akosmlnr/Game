using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066D RID: 1645
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		// Token: 0x060090CC RID: 37068 RVA: 0x0025C828 File Offset: 0x0025AA28
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingScreen()
		{
			Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LoadingScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr);
			LoadingScreen.NativeFieldInfoPtr_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "FADE_TIME");
			LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BACKGROUND_IMAGE_TIME");
			LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BACKGROUND_IMAGE_FADE_TIME");
			LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadingMessagesDatabase");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImages");
			LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "TutorialBackgroundImages");
			LoadingScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "Canvas");
			LoadingScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "Group");
			LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadStatusLabel");
			LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadingMessageLabel");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImage1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImage1");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImage2");
			LoadingScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "TutorialContainer");
			LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "CoopTutorialHint");
			LoadingScreen.NativeFieldInfoPtr_loadingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "loadingMessages");
			LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "currentBackgroundImageIndex");
			LoadingScreen.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "fadeRoutine");
			LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "animateBackgroundRoutine");
			LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "scaleBackgroundRoutine");
			LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "isLoadingTutorial");
			LoadingScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681363);
			LoadingScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681364);
			LoadingScreen.NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681365);
			LoadingScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681366);
			LoadingScreen.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681367);
			LoadingScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681368);
			LoadingScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681369);
			LoadingScreen.NativeMethodInfoPtr_AnimateBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681370);
			LoadingScreen.NativeMethodInfoPtr_Fade_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681371);
			LoadingScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681372);
			LoadingScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100681373);
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x060090CD RID: 37069 RVA: 0x0025CAD8 File Offset: 0x0025ACD8
		// (set) Token: 0x060090CE RID: 37070 RVA: 0x0025CB14 File Offset: 0x0025AD14
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x060090CF RID: 37071 RVA: 0x0025CB54 File Offset: 0x0025AD54
		public unsafe Il2CppReferenceArray<Sprite> ContextualBackgroundImages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x0025CB94 File Offset: 0x0025AD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263385, XrefRangeEnd = 263410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x0025CBD0 File Offset: 0x0025ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263410, XrefRangeEnd = 263415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x0025CC04 File Offset: 0x0025AE04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 263446, RefRangeEnd = 263451, XrefRangeStart = 263415, XrefRangeEnd = 263446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(bool loadingTutorial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref loadingTutorial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x0025CC44 File Offset: 0x0025AE44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 263464, RefRangeEnd = 263468, XrefRangeStart = 263451, XrefRangeEnd = 263464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x0025CC78 File Offset: 0x0025AE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263468, XrefRangeEnd = 263477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimateBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_AnimateBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x0025CCAC File Offset: 0x0025AEAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263491, RefRangeEnd = 263493, XrefRangeStart = 263477, XrefRangeEnd = 263491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fade(float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endAlpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Fade_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x0025CCEC File Offset: 0x0025AEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263493, XrefRangeEnd = 263496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x0025CD28 File Offset: 0x0025AF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263496, XrefRangeEnd = 263501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x0004561F File Offset: 0x0004381F
		public LoadingScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x060090D9 RID: 37081 RVA: 0x0025CD68 File Offset: 0x0025AF68
		// (set) Token: 0x060090DA RID: 37082 RVA: 0x00045628 File Offset: 0x00043828
		public unsafe static float FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x060090DB RID: 37083 RVA: 0x0025CD84 File Offset: 0x0025AF84
		// (set) Token: 0x060090DC RID: 37084 RVA: 0x00045636 File Offset: 0x00043836
		public unsafe static float BACKGROUND_IMAGE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x060090DD RID: 37085 RVA: 0x0025CDA0 File Offset: 0x0025AFA0
		// (set) Token: 0x060090DE RID: 37086 RVA: 0x00045644 File Offset: 0x00043844
		public unsafe static float BACKGROUND_IMAGE_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x060090DF RID: 37087 RVA: 0x0025CDBC File Offset: 0x0025AFBC
		// (set) Token: 0x060090E0 RID: 37088 RVA: 0x00045652 File Offset: 0x00043852
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x060090E1 RID: 37089 RVA: 0x0025CDE4 File Offset: 0x0025AFE4
		// (set) Token: 0x060090E2 RID: 37090 RVA: 0x0004566D File Offset: 0x0004386D
		public unsafe StringDatabase LoadingMessagesDatabase
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringDatabase>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x060090E3 RID: 37091 RVA: 0x0025CE14 File Offset: 0x0025B014
		// (set) Token: 0x060090E4 RID: 37092 RVA: 0x0004568C File Offset: 0x0004388C
		public unsafe Il2CppReferenceArray<Sprite> BackgroundImages
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImages);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x060090E5 RID: 37093 RVA: 0x0025CE44 File Offset: 0x0025B044
		// (set) Token: 0x060090E6 RID: 37094 RVA: 0x000456AB File Offset: 0x000438AB
		public unsafe Il2CppReferenceArray<Sprite> TutorialBackgroundImages
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x060090E7 RID: 37095 RVA: 0x0025CE74 File Offset: 0x0025B074
		// (set) Token: 0x060090E8 RID: 37096 RVA: 0x000456CA File Offset: 0x000438CA
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x060090E9 RID: 37097 RVA: 0x0025CEA4 File Offset: 0x0025B0A4
		// (set) Token: 0x060090EA RID: 37098 RVA: 0x000456E9 File Offset: 0x000438E9
		public unsafe CanvasGroup Group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x060090EB RID: 37099 RVA: 0x0025CED4 File Offset: 0x0025B0D4
		// (set) Token: 0x060090EC RID: 37100 RVA: 0x00045708 File Offset: 0x00043908
		public unsafe TextMeshProUGUI LoadStatusLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x060090ED RID: 37101 RVA: 0x0025CF04 File Offset: 0x0025B104
		// (set) Token: 0x060090EE RID: 37102 RVA: 0x00045727 File Offset: 0x00043927
		public unsafe TextMeshProUGUI LoadingMessageLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x060090EF RID: 37103 RVA: 0x0025CF34 File Offset: 0x0025B134
		// (set) Token: 0x060090F0 RID: 37104 RVA: 0x00045746 File Offset: 0x00043946
		public unsafe Image BackgroundImage1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x060090F1 RID: 37105 RVA: 0x0025CF64 File Offset: 0x0025B164
		// (set) Token: 0x060090F2 RID: 37106 RVA: 0x00045765 File Offset: 0x00043965
		public unsafe Image BackgroundImage2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x060090F3 RID: 37107 RVA: 0x0025CF94 File Offset: 0x0025B194
		// (set) Token: 0x060090F4 RID: 37108 RVA: 0x00045784 File Offset: 0x00043984
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x060090F5 RID: 37109 RVA: 0x0025CFC4 File Offset: 0x0025B1C4
		// (set) Token: 0x060090F6 RID: 37110 RVA: 0x000457A3 File Offset: 0x000439A3
		public unsafe RectTransform CoopTutorialHint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x060090F7 RID: 37111 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
		// (set) Token: 0x060090F8 RID: 37112 RVA: 0x000457C2 File Offset: 0x000439C2
		public unsafe Il2CppStringArray loadingMessages
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_loadingMessages);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_loadingMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x060090F9 RID: 37113 RVA: 0x0025D024 File Offset: 0x0025B224
		// (set) Token: 0x060090FA RID: 37114 RVA: 0x000457E1 File Offset: 0x000439E1
		public unsafe int currentBackgroundImageIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex)) = value;
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x060090FB RID: 37115 RVA: 0x0025D04C File Offset: 0x0025B24C
		// (set) Token: 0x060090FC RID: 37116 RVA: 0x000457FC File Offset: 0x000439FC
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_fadeRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x060090FD RID: 37117 RVA: 0x0025D07C File Offset: 0x0025B27C
		// (set) Token: 0x060090FE RID: 37118 RVA: 0x0004581B File Offset: 0x00043A1B
		public unsafe Coroutine animateBackgroundRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x060090FF RID: 37119 RVA: 0x0025D0AC File Offset: 0x0025B2AC
		// (set) Token: 0x06009100 RID: 37120 RVA: 0x0004583A File Offset: 0x00043A3A
		public unsafe Coroutine scaleBackgroundRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x06009101 RID: 37121 RVA: 0x0025D0DC File Offset: 0x0025B2DC
		// (set) Token: 0x06009102 RID: 37122 RVA: 0x00045859 File Offset: 0x00043A59
		public unsafe bool isLoadingTutorial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial)) = value;
			}
		}

		// Token: 0x04006210 RID: 25104
		private static readonly System.IntPtr NativeFieldInfoPtr_FADE_TIME;

		// Token: 0x04006211 RID: 25105
		private static readonly System.IntPtr NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME;

		// Token: 0x04006212 RID: 25106
		private static readonly System.IntPtr NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME;

		// Token: 0x04006213 RID: 25107
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006214 RID: 25108
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadingMessagesDatabase;

		// Token: 0x04006215 RID: 25109
		private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImages;

		// Token: 0x04006216 RID: 25110
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialBackgroundImages;

		// Token: 0x04006217 RID: 25111
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006218 RID: 25112
		private static readonly System.IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04006219 RID: 25113
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadStatusLabel;

		// Token: 0x0400621A RID: 25114
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadingMessageLabel;

		// Token: 0x0400621B RID: 25115
		private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage1;

		// Token: 0x0400621C RID: 25116
		private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage2;

		// Token: 0x0400621D RID: 25117
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x0400621E RID: 25118
		private static readonly System.IntPtr NativeFieldInfoPtr_CoopTutorialHint;

		// Token: 0x0400621F RID: 25119
		private static readonly System.IntPtr NativeFieldInfoPtr_loadingMessages;

		// Token: 0x04006220 RID: 25120
		private static readonly System.IntPtr NativeFieldInfoPtr_currentBackgroundImageIndex;

		// Token: 0x04006221 RID: 25121
		private static readonly System.IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04006222 RID: 25122
		private static readonly System.IntPtr NativeFieldInfoPtr_animateBackgroundRoutine;

		// Token: 0x04006223 RID: 25123
		private static readonly System.IntPtr NativeFieldInfoPtr_scaleBackgroundRoutine;

		// Token: 0x04006224 RID: 25124
		private static readonly System.IntPtr NativeFieldInfoPtr_isLoadingTutorial;

		// Token: 0x04006225 RID: 25125
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006226 RID: 25126
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006227 RID: 25127
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04006228 RID: 25128
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006229 RID: 25129
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400622A RID: 25130
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_Boolean_0;

		// Token: 0x0400622B RID: 25131
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400622C RID: 25132
		private static readonly System.IntPtr NativeMethodInfoPtr_AnimateBackground_Private_Void_0;

		// Token: 0x0400622D RID: 25133
		private static readonly System.IntPtr NativeMethodInfoPtr_Fade_Private_Void_Single_0;

		// Token: 0x0400622E RID: 25134
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400622F RID: 25135
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B7B RID: 2939
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<<AnimateBackground>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD07 RID: 56583 RVA: 0x0034A9DC File Offset: 0x00348BDC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique()
			{
				Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<<AnimateBackground>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>8__1");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<prevImage>5__2");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<i>5__3");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681374);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681375);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681376);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681377);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681378);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100681379);
			}

			// Token: 0x0600DD08 RID: 56584 RVA: 0x0034AAF8 File Offset: 0x00348CF8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD09 RID: 56585 RVA: 0x0034AB40 File Offset: 0x00348D40
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD0A RID: 56586 RVA: 0x0034AB74 File Offset: 0x00348D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263290, XrefRangeEnd = 263333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004439 RID: 17465
			// (get) Token: 0x0600DD0B RID: 56587 RVA: 0x0034ABB0 File Offset: 0x00348DB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD0C RID: 56588 RVA: 0x0034ABF0 File Offset: 0x00348DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263333, XrefRangeEnd = 263338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700443A RID: 17466
			// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x0034AC24 File Offset: 0x00348E24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD0E RID: 56590 RVA: 0x0006B4CC File Offset: 0x000696CC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004433 RID: 17459
			// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x0034AC64 File Offset: 0x00348E64
			// (set) Token: 0x0600DD10 RID: 56592 RVA: 0x0006B4D5 File Offset: 0x000696D5
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004434 RID: 17460
			// (get) Token: 0x0600DD11 RID: 56593 RVA: 0x0034AC8C File Offset: 0x00348E8C
			// (set) Token: 0x0600DD12 RID: 56594 RVA: 0x0006B4F0 File Offset: 0x000696F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004435 RID: 17461
			// (get) Token: 0x0600DD13 RID: 56595 RVA: 0x0034ACBC File Offset: 0x00348EBC
			// (set) Token: 0x0600DD14 RID: 56596 RVA: 0x0006B50F File Offset: 0x0006970F
			public unsafe LoadingScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004436 RID: 17462
			// (get) Token: 0x0600DD15 RID: 56597 RVA: 0x0034ACEC File Offset: 0x00348EEC
			// (set) Token: 0x0600DD16 RID: 56598 RVA: 0x0006B52E File Offset: 0x0006972E
			public unsafe LoadingScreen.__c__DisplayClass30_0 __8__1
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004437 RID: 17463
			// (get) Token: 0x0600DD17 RID: 56599 RVA: 0x0034AD1C File Offset: 0x00348F1C
			// (set) Token: 0x0600DD18 RID: 56600 RVA: 0x0006B54D File Offset: 0x0006974D
			public unsafe Image _prevImage_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004438 RID: 17464
			// (get) Token: 0x0600DD19 RID: 56601 RVA: 0x0034AD4C File Offset: 0x00348F4C
			// (set) Token: 0x0600DD1A RID: 56602 RVA: 0x0006B56C File Offset: 0x0006976C
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400949C RID: 38044
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400949D RID: 38045
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400949E RID: 38046
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400949F RID: 38047
			private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040094A0 RID: 38048
			private static readonly System.IntPtr NativeFieldInfoPtr__prevImage_5__2;

			// Token: 0x040094A1 RID: 38049
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040094A2 RID: 38050
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094A3 RID: 38051
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094A4 RID: 38052
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094A5 RID: 38053
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094A6 RID: 38054
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094A7 RID: 38055
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B7C RID: 2940
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD1B RID: 56603 RVA: 0x0034AD74 File Offset: 0x00348F74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr);
				LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, "nextImage");
				LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, 100681380);
				LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, 100681381);
			}

			// Token: 0x0600DD1C RID: 56604 RVA: 0x0034ADDC File Offset: 0x00348FDC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x0034AE18 File Offset: 0x00349018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263358, XrefRangeEnd = 263364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Transform_Single_PDM_0(Transform trans, float lerpTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x0006B587 File Offset: 0x00069787
			public __c__DisplayClass30_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443B RID: 17467
			// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x0034AE78 File Offset: 0x00349078
			// (set) Token: 0x0600DD20 RID: 56608 RVA: 0x0006B590 File Offset: 0x00069790
			public unsafe Image nextImage
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094A8 RID: 38056
			private static readonly System.IntPtr NativeFieldInfoPtr_nextImage;

			// Token: 0x040094A9 RID: 38057
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094AA RID: 38058
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0;

			// Token: 0x02000CD0 RID: 3280
			[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass30_0+<<AnimateBackground>g__ScaleRoutine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB17 RID: 60183 RVA: 0x00373280 File Offset: 0x00371480
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique()
				{
					Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, "<<AnimateBackground>g__ScaleRoutine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>1__state");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>2__current");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "trans");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "lerpTime");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>4__this");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<i>5__2");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681382);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681383);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681384);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681385);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681386);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681387);
				}

				// Token: 0x0600EB18 RID: 60184 RVA: 0x0037339C File Offset: 0x0037159C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB19 RID: 60185 RVA: 0x003733E4 File Offset: 0x003715E4
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB1A RID: 60186 RVA: 0x00373418 File Offset: 0x00371618
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263338, XrefRangeEnd = 263353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048CC RID: 18636
				// (get) Token: 0x0600EB1B RID: 60187 RVA: 0x00373454 File Offset: 0x00371654
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB1C RID: 60188 RVA: 0x00373494 File Offset: 0x00371694
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263353, XrefRangeEnd = 263358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048CD RID: 18637
				// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x003734C8 File Offset: 0x003716C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB1E RID: 60190 RVA: 0x000725A9 File Offset: 0x000707A9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048C6 RID: 18630
				// (get) Token: 0x0600EB1F RID: 60191 RVA: 0x00373508 File Offset: 0x00371708
				// (set) Token: 0x0600EB20 RID: 60192 RVA: 0x000725B2 File Offset: 0x000707B2
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048C7 RID: 18631
				// (get) Token: 0x0600EB21 RID: 60193 RVA: 0x00373530 File Offset: 0x00371730
				// (set) Token: 0x0600EB22 RID: 60194 RVA: 0x000725CD File Offset: 0x000707CD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048C8 RID: 18632
				// (get) Token: 0x0600EB23 RID: 60195 RVA: 0x00373560 File Offset: 0x00371760
				// (set) Token: 0x0600EB24 RID: 60196 RVA: 0x000725EC File Offset: 0x000707EC
				public unsafe Transform trans
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048C9 RID: 18633
				// (get) Token: 0x0600EB25 RID: 60197 RVA: 0x00373590 File Offset: 0x00371790
				// (set) Token: 0x0600EB26 RID: 60198 RVA: 0x0007260B File Offset: 0x0007080B
				public unsafe float lerpTime
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime)) = value;
					}
				}

				// Token: 0x170048CA RID: 18634
				// (get) Token: 0x0600EB27 RID: 60199 RVA: 0x003735B8 File Offset: 0x003717B8
				// (set) Token: 0x0600EB28 RID: 60200 RVA: 0x00072626 File Offset: 0x00070826
				public unsafe LoadingScreen.__c__DisplayClass30_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048CB RID: 18635
				// (get) Token: 0x0600EB29 RID: 60201 RVA: 0x003735E8 File Offset: 0x003717E8
				// (set) Token: 0x0600EB2A RID: 60202 RVA: 0x00072645 File Offset: 0x00070845
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009D3D RID: 40253
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D3E RID: 40254
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D3F RID: 40255
				private static readonly System.IntPtr NativeFieldInfoPtr_trans;

				// Token: 0x04009D40 RID: 40256
				private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

				// Token: 0x04009D41 RID: 40257
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D42 RID: 40258
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009D43 RID: 40259
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D44 RID: 40260
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D45 RID: 40261
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D46 RID: 40262
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D47 RID: 40263
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D48 RID: 40264
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B7D RID: 2941
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD21 RID: 56609 RVA: 0x0034AEA8 File Offset: 0x003490A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr);
				LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "endAlpha");
				LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, 100681388);
				LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, 100681389);
			}

			// Token: 0x0600DD22 RID: 56610 RVA: 0x0034AF24 File Offset: 0x00349124
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x0034AF60 File Offset: 0x00349160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263380, XrefRangeEnd = 263385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DD24 RID: 56612 RVA: 0x0006B5AF File Offset: 0x000697AF
			public __c__DisplayClass31_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443C RID: 17468
			// (get) Token: 0x0600DD25 RID: 56613 RVA: 0x0034AFA0 File Offset: 0x003491A0
			// (set) Token: 0x0600DD26 RID: 56614 RVA: 0x0006B5B8 File Offset: 0x000697B8
			public unsafe float endAlpha
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha)) = value;
				}
			}

			// Token: 0x1700443D RID: 17469
			// (get) Token: 0x0600DD27 RID: 56615 RVA: 0x0034AFC8 File Offset: 0x003491C8
			// (set) Token: 0x0600DD28 RID: 56616 RVA: 0x0006B5D3 File Offset: 0x000697D3
			public unsafe LoadingScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094AB RID: 38059
			private static readonly System.IntPtr NativeFieldInfoPtr_endAlpha;

			// Token: 0x040094AC RID: 38060
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094AD RID: 38061
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094AE RID: 38062
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD1 RID: 3281
			[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass31_0+<<Fade>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB2B RID: 60203 RVA: 0x00373610 File Offset: 0x00371810
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "<<Fade>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681390);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681391);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681392);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681393);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681394);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681395);
				}

				// Token: 0x0600EB2C RID: 60204 RVA: 0x00373718 File Offset: 0x00371918
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB2D RID: 60205 RVA: 0x00373760 File Offset: 0x00371960
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB2E RID: 60206 RVA: 0x00373794 File Offset: 0x00371994
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263364, XrefRangeEnd = 263375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048D3 RID: 18643
				// (get) Token: 0x0600EB2F RID: 60207 RVA: 0x003737D0 File Offset: 0x003719D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB30 RID: 60208 RVA: 0x00373810 File Offset: 0x00371A10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263375, XrefRangeEnd = 263380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048D4 RID: 18644
				// (get) Token: 0x0600EB31 RID: 60209 RVA: 0x00373844 File Offset: 0x00371A44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB32 RID: 60210 RVA: 0x00072660 File Offset: 0x00070860
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048CE RID: 18638
				// (get) Token: 0x0600EB33 RID: 60211 RVA: 0x00373884 File Offset: 0x00371A84
				// (set) Token: 0x0600EB34 RID: 60212 RVA: 0x00072669 File Offset: 0x00070869
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048CF RID: 18639
				// (get) Token: 0x0600EB35 RID: 60213 RVA: 0x003738AC File Offset: 0x00371AAC
				// (set) Token: 0x0600EB36 RID: 60214 RVA: 0x00072684 File Offset: 0x00070884
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048D0 RID: 18640
				// (get) Token: 0x0600EB37 RID: 60215 RVA: 0x003738DC File Offset: 0x00371ADC
				// (set) Token: 0x0600EB38 RID: 60216 RVA: 0x000726A3 File Offset: 0x000708A3
				public unsafe LoadingScreen.__c__DisplayClass31_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass31_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048D1 RID: 18641
				// (get) Token: 0x0600EB39 RID: 60217 RVA: 0x0037390C File Offset: 0x00371B0C
				// (set) Token: 0x0600EB3A RID: 60218 RVA: 0x000726C2 File Offset: 0x000708C2
				public unsafe float _startAlpha_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x170048D2 RID: 18642
				// (get) Token: 0x0600EB3B RID: 60219 RVA: 0x00373934 File Offset: 0x00371B34
				// (set) Token: 0x0600EB3C RID: 60220 RVA: 0x000726DD File Offset: 0x000708DD
				public unsafe float _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009D49 RID: 40265
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D4A RID: 40266
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D4B RID: 40267
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D4C RID: 40268
				private static readonly System.IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009D4D RID: 40269
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009D4E RID: 40270
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D4F RID: 40271
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D50 RID: 40272
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D51 RID: 40273
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D52 RID: 40274
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D53 RID: 40275
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
