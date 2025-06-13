using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200052C RID: 1324
	public class Bungalow : Property
	{
		// Token: 0x0600741F RID: 29727 RVA: 0x001FDCEC File Offset: 0x001FBEEC
		// Note: this type is marked as 'beforefieldinit'.
		static Bungalow()
		{
			Il2CppClassPointerStore<Bungalow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Bungalow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow>.NativeClassPtr);
			Bungalow.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "ModelContainer");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677943);
			Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677944);
			Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677945);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677946);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677947);
			Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677948);
			Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677949);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x001FDDE4 File Offset: 0x001FBFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227629, XrefRangeEnd = 227633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x001FDE20 File Offset: 0x001FC020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227633, XrefRangeEnd = 227756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x001FDE54 File Offset: 0x001FC054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227756, XrefRangeEnd = 227760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bungalow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x001FDE90 File Offset: 0x001FC090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227760, XrefRangeEnd = 227761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x001FDECC File Offset: 0x001FC0CC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x001FDF08 File Offset: 0x001FC108
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x001FDF44 File Offset: 0x001FC144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227761, XrefRangeEnd = 227762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x00037097 File Offset: 0x00035297
		public Bungalow(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06007428 RID: 29736 RVA: 0x001FDF80 File Offset: 0x001FC180
		// (set) Token: 0x06007429 RID: 29737 RVA: 0x000370A0 File Offset: 0x000352A0
		public unsafe Transform ModelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600742A RID: 29738 RVA: 0x001FDFB0 File Offset: 0x001FC1B0
		// (set) Token: 0x0600742B RID: 29739 RVA: 0x000370BF File Offset: 0x000352BF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600742C RID: 29740 RVA: 0x001FDFD8 File Offset: 0x001FC1D8
		// (set) Token: 0x0600742D RID: 29741 RVA: 0x000370DA File Offset: 0x000352DA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F3D RID: 20285
		private static readonly System.IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04004F3E RID: 20286
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F3F RID: 20287
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F40 RID: 20288
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004F41 RID: 20289
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004F42 RID: 20290
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F43 RID: 20291
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F44 RID: 20292
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F45 RID: 20293
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F46 RID: 20294
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000ACE RID: 2766
		[ObfuscatedName("ScheduleOne.Property.Bungalow+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D718 RID: 55064 RVA: 0x00339BD4 File Offset: 0x00337DD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr);
				Bungalow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9");
				Bungalow.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_0");
				Bungalow.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_1");
				Bungalow.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_2");
				Bungalow.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_3");
				Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677951);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677952);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677953);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677954);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677955);
			}

			// Token: 0x0600D719 RID: 55065 RVA: 0x00339CC8 File Offset: 0x00337EC8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D71A RID: 55066 RVA: 0x00339D04 File Offset: 0x00337F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227619, XrefRangeEnd = 227621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D71B RID: 55067 RVA: 0x00339D54 File Offset: 0x00337F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227621, XrefRangeEnd = 227623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__2_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}

			// Token: 0x0600D71C RID: 55068 RVA: 0x00339DA4 File Offset: 0x00337FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227623, XrefRangeEnd = 227625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_2(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D71D RID: 55069 RVA: 0x00339DF4 File Offset: 0x00337FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227625, XrefRangeEnd = 227629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_3(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D71E RID: 55070 RVA: 0x00068714 File Offset: 0x00066914
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004277 RID: 17015
			// (get) Token: 0x0600D71F RID: 55071 RVA: 0x00339E44 File Offset: 0x00338044
			// (set) Token: 0x0600D720 RID: 55072 RVA: 0x0006871D File Offset: 0x0006691D
			public unsafe static Bungalow.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bungalow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004278 RID: 17016
			// (get) Token: 0x0600D721 RID: 55073 RVA: 0x00339E6C File Offset: 0x0033806C
			// (set) Token: 0x0600D722 RID: 55074 RVA: 0x0006872F File Offset: 0x0006692F
			public unsafe static Il2CppSystem.Func<BuildableItem, bool> __9__2_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004279 RID: 17017
			// (get) Token: 0x0600D723 RID: 55075 RVA: 0x00339E94 File Offset: 0x00338094
			// (set) Token: 0x0600D724 RID: 55076 RVA: 0x00068741 File Offset: 0x00066941
			public unsafe static Il2CppSystem.Func<BuildableItem, Pot> __9__2_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427A RID: 17018
			// (get) Token: 0x0600D725 RID: 55077 RVA: 0x00339EBC File Offset: 0x003380BC
			// (set) Token: 0x0600D726 RID: 55078 RVA: 0x00068753 File Offset: 0x00066953
			public unsafe static Il2CppSystem.Func<BuildableItem, bool> __9__2_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427B RID: 17019
			// (get) Token: 0x0600D727 RID: 55079 RVA: 0x00339EE4 File Offset: 0x003380E4
			// (set) Token: 0x0600D728 RID: 55080 RVA: 0x00068765 File Offset: 0x00066965
			public unsafe static Il2CppSystem.Predicate<Additive> __9__2_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009127 RID: 37159
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009128 RID: 37160
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009129 RID: 37161
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400912A RID: 37162
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x0400912B RID: 37163
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x0400912C RID: 37164
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400912D RID: 37165
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x0400912E RID: 37166
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0;

			// Token: 0x0400912F RID: 37167
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0;

			// Token: 0x04009130 RID: 37168
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0;
		}
	}
}
