using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000666 RID: 1638
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x06009031 RID: 36913 RVA: 0x0025AAA0 File Offset: 0x00258CA0
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsCanvas()
		{
			Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "InputPromptsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr);
			InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "InputPromptsContainer");
			InputPromptsCanvas.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Modules");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModuleLabel>k__BackingField");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModule>k__BackingField");
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681300);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681301);
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681302);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681303);
			InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681304);
			InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681305);
			InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100681306);
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06009032 RID: 36914 RVA: 0x0025ABAC File Offset: 0x00258DAC
		// (set) Token: 0x06009033 RID: 36915 RVA: 0x0025ABE4 File Offset: 0x00258DE4
		public unsafe string currentModuleLabel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x0025AC28 File Offset: 0x00258E28
		// (set) Token: 0x06009035 RID: 36917 RVA: 0x0025AC68 File Offset: 0x00258E68
		public unsafe RectTransform currentModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x0025ACAC File Offset: 0x00258EAC
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 262295, RefRangeEnd = 262338, XrefRangeStart = 262260, XrefRangeEnd = 262295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x0025ACF0 File Offset: 0x00258EF0
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 262349, RefRangeEnd = 262390, XrefRangeStart = 262338, XrefRangeEnd = 262349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0025AD24 File Offset: 0x00258F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262390, XrefRangeEnd = 262403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x000450A3 File Offset: 0x000432A3
		public InputPromptsCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x0025AD60 File Offset: 0x00258F60
		// (set) Token: 0x0600903B RID: 36923 RVA: 0x000450AC File Offset: 0x000432AC
		public unsafe RectTransform InputPromptsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x0025AD90 File Offset: 0x00258F90
		// (set) Token: 0x0600903D RID: 36925 RVA: 0x000450CB File Offset: 0x000432CB
		public unsafe List<InputPromptsCanvas.Module> Modules
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsCanvas.Module>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x0025ADC0 File Offset: 0x00258FC0
		// (set) Token: 0x0600903F RID: 36927 RVA: 0x000450EA File Offset: 0x000432EA
		public unsafe string _currentModuleLabel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x0025ADE8 File Offset: 0x00258FE8
		// (set) Token: 0x06009041 RID: 36929 RVA: 0x00045109 File Offset: 0x00043309
		public unsafe RectTransform _currentModule_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061AD RID: 25005
		private static readonly System.IntPtr NativeFieldInfoPtr_InputPromptsContainer;

		// Token: 0x040061AE RID: 25006
		private static readonly System.IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x040061AF RID: 25007
		private static readonly System.IntPtr NativeFieldInfoPtr__currentModuleLabel_k__BackingField;

		// Token: 0x040061B0 RID: 25008
		private static readonly System.IntPtr NativeFieldInfoPtr__currentModule_k__BackingField;

		// Token: 0x040061B1 RID: 25009
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0;

		// Token: 0x040061B2 RID: 25010
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0;

		// Token: 0x040061B3 RID: 25011
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0;

		// Token: 0x040061B4 RID: 25012
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0;

		// Token: 0x040061B5 RID: 25013
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_0;

		// Token: 0x040061B6 RID: 25014
		private static readonly System.IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_0;

		// Token: 0x040061B7 RID: 25015
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B78 RID: 2936
		[System.Serializable]
		public class Module : Il2CppSystem.Object
		{
			// Token: 0x0600DCF2 RID: 56562 RVA: 0x0034A664 File Offset: 0x00348864
			// Note: this type is marked as 'beforefieldinit'.
			static Module()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Module");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr);
				InputPromptsCanvas.Module.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "key");
				InputPromptsCanvas.Module.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "module");
				InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, 100681307);
			}

			// Token: 0x0600DCF3 RID: 56563 RVA: 0x0034A6CC File Offset: 0x003488CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Module() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCF4 RID: 56564 RVA: 0x0006B430 File Offset: 0x00069630
			public Module(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442E RID: 17454
			// (get) Token: 0x0600DCF5 RID: 56565 RVA: 0x0034A708 File Offset: 0x00348908
			// (set) Token: 0x0600DCF6 RID: 56566 RVA: 0x0006B439 File Offset: 0x00069639
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700442F RID: 17455
			// (get) Token: 0x0600DCF7 RID: 56567 RVA: 0x0034A730 File Offset: 0x00348930
			// (set) Token: 0x0600DCF8 RID: 56568 RVA: 0x0006B458 File Offset: 0x00069658
			public unsafe GameObject module
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009492 RID: 38034
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009493 RID: 38035
			private static readonly System.IntPtr NativeFieldInfoPtr_module;

			// Token: 0x04009494 RID: 38036
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B79 RID: 2937
		[ObfuscatedName("ScheduleOne.UI.InputPromptsCanvas+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCF9 RID: 56569 RVA: 0x0034A760 File Offset: 0x00348960
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, "key");
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100681308);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100681309);
			}

			// Token: 0x0600DCFA RID: 56570 RVA: 0x0034A7C8 File Offset: 0x003489C8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCFB RID: 56571 RVA: 0x0034A804 File Offset: 0x00348A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadModule_b__0(InputPromptsCanvas.Module x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DCFC RID: 56572 RVA: 0x0006B477 File Offset: 0x00069677
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004430 RID: 17456
			// (get) Token: 0x0600DCFD RID: 56573 RVA: 0x0034A854 File Offset: 0x00348A54
			// (set) Token: 0x0600DCFE RID: 56574 RVA: 0x0006B480 File Offset: 0x00069680
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009495 RID: 38037
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009496 RID: 38038
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009497 RID: 38039
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0;
		}
	}
}
