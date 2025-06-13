using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.CharacterCreator;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063C RID: 1596
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x06008C1B RID: 35867 RVA: 0x0024E470 File Offset: 0x0024C670
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreator()
		{
			Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CharacterCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr);
			CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Fields");
			CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<ActiveSettings>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Container");
			CharacterCreator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CameraPosition");
			CharacterCreator.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "RigContainer");
			CharacterCreator.NativeFieldInfoPtr_Rig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Rig");
			CharacterCreator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Canvas");
			CharacterCreator.NativeFieldInfoPtr_CanvasAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CanvasAnimation");
			CharacterCreator.NativeFieldInfoPtr_DemoCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DemoCreator");
			CharacterCreator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DefaultSettings");
			CharacterCreator.NativeFieldInfoPtr_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Presets");
			CharacterCreator.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onComplete");
			CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onCompleteWithClothing");
			CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "lastSelectedClothingDefinitions");
			CharacterCreator.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "rigTargetY");
			CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680805);
			CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680806);
			CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680807);
			CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680808);
			CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680809);
			CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680810);
			CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680811);
			CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680812);
			CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680813);
			CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680814);
			CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680815);
			CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680816);
			CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680817);
			CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680818);
			CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680819);
			CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680820);
			CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680821);
			CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680822);
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06008C1C RID: 35868 RVA: 0x0024E748 File Offset: 0x0024C948
		// (set) Token: 0x06008C1D RID: 35869 RVA: 0x0024E784 File Offset: 0x0024C984
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06008C1E RID: 35870 RVA: 0x0024E7C4 File Offset: 0x0024C9C4
		// (set) Token: 0x06008C1F RID: 35871 RVA: 0x0024E804 File Offset: 0x0024CA04
		public unsafe BasicAvatarSettings ActiveSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x0024E848 File Offset: 0x0024CA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257644, XrefRangeEnd = 257657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x0024E884 File Offset: 0x0024CA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257657, XrefRangeEnd = 257663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x0024E8C0 File Offset: 0x0024CAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257663, XrefRangeEnd = 257667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x0024E8F4 File Offset: 0x0024CAF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257727, RefRangeEnd = 257729, XrefRangeStart = 257667, XrefRangeEnd = 257727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialSettings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref showUI;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x0024E944 File Offset: 0x0024CB44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257744, RefRangeEnd = 257747, XrefRangeStart = 257729, XrefRangeEnd = 257744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x0024E978 File Offset: 0x0024CB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257747, XrefRangeEnd = 257753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x0024E9AC File Offset: 0x0024CBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257756, RefRangeEnd = 257757, XrefRangeStart = 257753, XrefRangeEnd = 257756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x0024E9E0 File Offset: 0x0024CBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257757, XrefRangeEnd = 257811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x0024EA14 File Offset: 0x0024CC14
		[CallerCount(0)]
		public unsafe void SliderChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x0024EA54 File Offset: 0x0024CC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257831, RefRangeEnd = 257832, XrefRangeStart = 257811, XrefRangeEnd = 257831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x0024EAF8 File Offset: 0x0024CCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257832, XrefRangeEnd = 257870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x0024EB3C File Offset: 0x0024CD3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257874, RefRangeEnd = 257875, XrefRangeStart = 257870, XrefRangeEnd = 257874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCategory(CharacterCreator.ECategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x0024EB7C File Offset: 0x0024CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257875, XrefRangeEnd = 257892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x0024EBB8 File Offset: 0x0024CDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257892, XrefRangeEnd = 257897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00042B80 File Offset: 0x00040D80
		public CharacterCreator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x06008C2F RID: 35887 RVA: 0x0024EBF8 File Offset: 0x0024CDF8
		// (set) Token: 0x06008C30 RID: 35888 RVA: 0x00042B89 File Offset: 0x00040D89
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x06008C31 RID: 35889 RVA: 0x0024EC20 File Offset: 0x0024CE20
		// (set) Token: 0x06008C32 RID: 35890 RVA: 0x00042BA4 File Offset: 0x00040DA4
		public unsafe List<BaseCharacterCreatorField> Fields
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseCharacterCreatorField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x0024EC50 File Offset: 0x0024CE50
		// (set) Token: 0x06008C34 RID: 35892 RVA: 0x00042BC3 File Offset: 0x00040DC3
		public unsafe BasicAvatarSettings _ActiveSettings_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x0024EC80 File Offset: 0x0024CE80
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x00042BE2 File Offset: 0x00040DE2
		public unsafe Transform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x06008C37 RID: 35895 RVA: 0x0024ECB0 File Offset: 0x0024CEB0
		// (set) Token: 0x06008C38 RID: 35896 RVA: 0x00042C01 File Offset: 0x00040E01
		public unsafe Transform CameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x06008C39 RID: 35897 RVA: 0x0024ECE0 File Offset: 0x0024CEE0
		// (set) Token: 0x06008C3A RID: 35898 RVA: 0x00042C20 File Offset: 0x00040E20
		public unsafe Transform RigContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x06008C3B RID: 35899 RVA: 0x0024ED10 File Offset: 0x0024CF10
		// (set) Token: 0x06008C3C RID: 35900 RVA: 0x00042C3F File Offset: 0x00040E3F
		public unsafe Avatar Rig
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x0024ED40 File Offset: 0x0024CF40
		// (set) Token: 0x06008C3E RID: 35902 RVA: 0x00042C5E File Offset: 0x00040E5E
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x0024ED70 File Offset: 0x0024CF70
		// (set) Token: 0x06008C40 RID: 35904 RVA: 0x00042C7D File Offset: 0x00040E7D
		public unsafe Animation CanvasAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x06008C41 RID: 35905 RVA: 0x0024EDA0 File Offset: 0x0024CFA0
		// (set) Token: 0x06008C42 RID: 35906 RVA: 0x00042C9C File Offset: 0x00040E9C
		public unsafe bool DemoCreator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator)) = value;
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x0024EDC8 File Offset: 0x0024CFC8
		// (set) Token: 0x06008C44 RID: 35908 RVA: 0x00042CB7 File Offset: 0x00040EB7
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x0024EDF8 File Offset: 0x0024CFF8
		// (set) Token: 0x06008C46 RID: 35910 RVA: 0x00042CD6 File Offset: 0x00040ED6
		public unsafe List<BasicAvatarSettings> Presets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x0024EE28 File Offset: 0x0024D028
		// (set) Token: 0x06008C48 RID: 35912 RVA: 0x00042CF5 File Offset: 0x00040EF5
		public unsafe UnityEvent<BasicAvatarSettings> onComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x0024EE58 File Offset: 0x0024D058
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x00042D14 File Offset: 0x00040F14
		public unsafe UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings, List<ClothingInstance>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x0024EE88 File Offset: 0x0024D088
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x00042D33 File Offset: 0x00040F33
		public unsafe Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ClothingDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x0024EEB8 File Offset: 0x0024D0B8
		// (set) Token: 0x06008C4E RID: 35918 RVA: 0x00042D52 File Offset: 0x00040F52
		public unsafe float rigTargetY
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x04005F1C RID: 24348
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005F1D RID: 24349
		private static readonly System.IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04005F1E RID: 24350
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSettings_k__BackingField;

		// Token: 0x04005F1F RID: 24351
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005F20 RID: 24352
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005F21 RID: 24353
		private static readonly System.IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04005F22 RID: 24354
		private static readonly System.IntPtr NativeFieldInfoPtr_Rig;

		// Token: 0x04005F23 RID: 24355
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005F24 RID: 24356
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasAnimation;

		// Token: 0x04005F25 RID: 24357
		private static readonly System.IntPtr NativeFieldInfoPtr_DemoCreator;

		// Token: 0x04005F26 RID: 24358
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005F27 RID: 24359
		private static readonly System.IntPtr NativeFieldInfoPtr_Presets;

		// Token: 0x04005F28 RID: 24360
		private static readonly System.IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04005F29 RID: 24361
		private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteWithClothing;

		// Token: 0x04005F2A RID: 24362
		private static readonly System.IntPtr NativeFieldInfoPtr_lastSelectedClothingDefinitions;

		// Token: 0x04005F2B RID: 24363
		private static readonly System.IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04005F2C RID: 24364
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005F2D RID: 24365
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005F2E RID: 24366
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x04005F2F RID: 24367
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04005F30 RID: 24368
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005F31 RID: 24369
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005F32 RID: 24370
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F33 RID: 24371
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04005F34 RID: 24372
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowUI_Public_Void_0;

		// Token: 0x04005F35 RID: 24373
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005F36 RID: 24374
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableStuff_Public_Void_0;

		// Token: 0x04005F37 RID: 24375
		private static readonly System.IntPtr NativeMethodInfoPtr_Done_Public_Void_0;

		// Token: 0x04005F38 RID: 24376
		private static readonly System.IntPtr NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0;

		// Token: 0x04005F39 RID: 24377
		private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0;

		// Token: 0x04005F3A RID: 24378
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectPreset_Public_Void_String_0;

		// Token: 0x04005F3B RID: 24379
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0;

		// Token: 0x04005F3C RID: 24380
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F3D RID: 24381
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B5A RID: 2906
		[OriginalName("Assembly-CSharp.dll", "", "ECategory")]
		public enum ECategory
		{
			// Token: 0x040093C9 RID: 37833
			Body,
			// Token: 0x040093CA RID: 37834
			Hair,
			// Token: 0x040093CB RID: 37835
			Face,
			// Token: 0x040093CC RID: 37836
			Eyes,
			// Token: 0x040093CD RID: 37837
			Eyebrows,
			// Token: 0x040093CE RID: 37838
			Clothing,
			// Token: 0x040093CF RID: 37839
			Accessories
		}

		// Token: 0x02000B5B RID: 2907
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<<Close>g__Close|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DBA7 RID: 56231 RVA: 0x00346BC4 File Offset: 0x00344DC4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique()
			{
				Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<<Close>g__Close|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>1__state");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>2__current");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>4__this");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680823);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680824);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680825);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680826);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680827);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680828);
			}

			// Token: 0x0600DBA8 RID: 56232 RVA: 0x00346CA4 File Offset: 0x00344EA4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBA9 RID: 56233 RVA: 0x00346CEC File Offset: 0x00344EEC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBAA RID: 56234 RVA: 0x00346D20 File Offset: 0x00344F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257621, XrefRangeEnd = 257636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043C3 RID: 17347
			// (get) Token: 0x0600DBAB RID: 56235 RVA: 0x00346D5C File Offset: 0x00344F5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DBAC RID: 56236 RVA: 0x00346D9C File Offset: 0x00344F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257636, XrefRangeEnd = 257641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043C4 RID: 17348
			// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x00346DD0 File Offset: 0x00344FD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DBAE RID: 56238 RVA: 0x0006A93D File Offset: 0x00068B3D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C0 RID: 17344
			// (get) Token: 0x0600DBAF RID: 56239 RVA: 0x00346E10 File Offset: 0x00345010
			// (set) Token: 0x0600DBB0 RID: 56240 RVA: 0x0006A946 File Offset: 0x00068B46
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043C1 RID: 17345
			// (get) Token: 0x0600DBB1 RID: 56241 RVA: 0x00346E38 File Offset: 0x00345038
			// (set) Token: 0x0600DBB2 RID: 56242 RVA: 0x0006A961 File Offset: 0x00068B61
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C2 RID: 17346
			// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x00346E68 File Offset: 0x00345068
			// (set) Token: 0x0600DBB4 RID: 56244 RVA: 0x0006A980 File Offset: 0x00068B80
			public unsafe CharacterCreator __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093D0 RID: 37840
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093D1 RID: 37841
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093D2 RID: 37842
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093D3 RID: 37843
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093D4 RID: 37844
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093D5 RID: 37845
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093D6 RID: 37846
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093D7 RID: 37847
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093D8 RID: 37848
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBB5 RID: 56245 RVA: 0x00346E98 File Offset: 0x00345098
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr);
				CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, "presetName");
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680829);
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680830);
			}

			// Token: 0x0600DBB6 RID: 56246 RVA: 0x00346F00 File Offset: 0x00345100
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBB7 RID: 56247 RVA: 0x00346F3C File Offset: 0x0034513C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257641, XrefRangeEnd = 257644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectPreset_b__0(BasicAvatarSettings p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DBB8 RID: 56248 RVA: 0x0006A99F File Offset: 0x00068B9F
			public __c__DisplayClass33_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C5 RID: 17349
			// (get) Token: 0x0600DBB9 RID: 56249 RVA: 0x00346F8C File Offset: 0x0034518C
			// (set) Token: 0x0600DBBA RID: 56250 RVA: 0x0006A9A8 File Offset: 0x00068BA8
			public unsafe string presetName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093D9 RID: 37849
			private static readonly System.IntPtr NativeFieldInfoPtr_presetName;

			// Token: 0x040093DA RID: 37850
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093DB RID: 37851
			private static readonly System.IntPtr NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0;
		}

		// Token: 0x02000B5D RID: 2909
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>
		{
			// Token: 0x040093DC RID: 37852
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0, Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
