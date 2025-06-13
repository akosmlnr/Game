using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061F RID: 1567
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x06008931 RID: 35121 RVA: 0x002461F0 File Offset: 0x002443F0
		// Note: this type is marked as 'beforefieldinit'.
		static MugshotGenerator()
		{
			Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "MugshotGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr);
			MugshotGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "OutputPath");
			MugshotGenerator.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Settings");
			MugshotGenerator.NativeFieldInfoPtr_MugshotRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "MugshotRig");
			MugshotGenerator.NativeFieldInfoPtr_Generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Generator");
			MugshotGenerator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "DefaultSettings");
			MugshotGenerator.NativeFieldInfoPtr_LookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "LookAtPosition");
			MugshotGenerator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "finalTexture");
			MugshotGenerator.NativeFieldInfoPtr_generate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "generate");
			MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680520);
			MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680521);
			MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680522);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680523);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680524);
			MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680525);
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x00246338 File Offset: 0x00244538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255120, XrefRangeEnd = 255126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00246374 File Offset: 0x00244574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255126, XrefRangeEnd = 255135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x002463A8 File Offset: 0x002445A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255135, XrefRangeEnd = 255145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x002463DC File Offset: 0x002445DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255145, XrefRangeEnd = 255146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x00246410 File Offset: 0x00244610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255187, RefRangeEnd = 255189, XrefRangeStart = 255146, XrefRangeEnd = 255187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot(AvatarSettings settings, bool fileToFile, Il2CppSystem.Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref fileToFile;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x00246474 File Offset: 0x00244674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255189, XrefRangeEnd = 255192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MugshotGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x00040FEE File Offset: 0x0003F1EE
		public MugshotGenerator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x002464B0 File Offset: 0x002446B0
		// (set) Token: 0x0600893A RID: 35130 RVA: 0x00040FF7 File Offset: 0x0003F1F7
		public unsafe string OutputPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x002464D8 File Offset: 0x002446D8
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x00041016 File Offset: 0x0003F216
		public unsafe AvatarSettings Settings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x00246508 File Offset: 0x00244708
		// (set) Token: 0x0600893E RID: 35134 RVA: 0x00041035 File Offset: 0x0003F235
		public unsafe Avatar MugshotRig
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600893F RID: 35135 RVA: 0x00246538 File Offset: 0x00244738
		// (set) Token: 0x06008940 RID: 35136 RVA: 0x00041054 File Offset: 0x0003F254
		public unsafe IconGenerator Generator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06008941 RID: 35137 RVA: 0x00246568 File Offset: 0x00244768
		// (set) Token: 0x06008942 RID: 35138 RVA: 0x00041073 File Offset: 0x0003F273
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06008943 RID: 35139 RVA: 0x00246598 File Offset: 0x00244798
		// (set) Token: 0x06008944 RID: 35140 RVA: 0x00041092 File Offset: 0x0003F292
		public unsafe Transform LookAtPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06008945 RID: 35141 RVA: 0x002465C8 File Offset: 0x002447C8
		// (set) Token: 0x06008946 RID: 35142 RVA: 0x000410B1 File Offset: 0x0003F2B1
		public unsafe Texture2D finalTexture
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06008947 RID: 35143 RVA: 0x002465F8 File Offset: 0x002447F8
		// (set) Token: 0x06008948 RID: 35144 RVA: 0x000410D0 File Offset: 0x0003F2D0
		public unsafe bool generate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate)) = value;
			}
		}

		// Token: 0x04005D63 RID: 23907
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x04005D64 RID: 23908
		private static readonly System.IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04005D65 RID: 23909
		private static readonly System.IntPtr NativeFieldInfoPtr_MugshotRig;

		// Token: 0x04005D66 RID: 23910
		private static readonly System.IntPtr NativeFieldInfoPtr_Generator;

		// Token: 0x04005D67 RID: 23911
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005D68 RID: 23912
		private static readonly System.IntPtr NativeFieldInfoPtr_LookAtPosition;

		// Token: 0x04005D69 RID: 23913
		private static readonly System.IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x04005D6A RID: 23914
		private static readonly System.IntPtr NativeFieldInfoPtr_generate;

		// Token: 0x04005D6B RID: 23915
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005D6C RID: 23916
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005D6D RID: 23917
		private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0;

		// Token: 0x04005D6E RID: 23918
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_0;

		// Token: 0x04005D6F RID: 23919
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0;

		// Token: 0x04005D70 RID: 23920
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B42 RID: 2882
		[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAE6 RID: 56038 RVA: 0x00344A10 File Offset: 0x00342C10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "fileToFile");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "settings");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "callback");
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680526);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680527);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680528);
			}

			// Token: 0x0600DAE7 RID: 56039 RVA: 0x00344AC8 File Offset: 0x00342CC8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAE8 RID: 56040 RVA: 0x00344B04 File Offset: 0x00342D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255110, XrefRangeEnd = 255115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DAE9 RID: 56041 RVA: 0x00344B44 File Offset: 0x00342D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255115, XrefRangeEnd = 255120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateMugshot_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DAEA RID: 56042 RVA: 0x0006A2E5 File Offset: 0x000684E5
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0600DAEB RID: 56043 RVA: 0x00344B80 File Offset: 0x00342D80
			// (set) Token: 0x0600DAEC RID: 56044 RVA: 0x0006A2EE File Offset: 0x000684EE
			public unsafe MugshotGenerator __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00344BB0 File Offset: 0x00342DB0
			// (set) Token: 0x0600DAEE RID: 56046 RVA: 0x0006A30D File Offset: 0x0006850D
			public unsafe bool fileToFile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile)) = value;
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600DAEF RID: 56047 RVA: 0x00344BD8 File Offset: 0x00342DD8
			// (set) Token: 0x0600DAF0 RID: 56048 RVA: 0x0006A328 File Offset: 0x00068528
			public unsafe AvatarSettings settings
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004389 RID: 17289
			// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x00344C08 File Offset: 0x00342E08
			// (set) Token: 0x0600DAF2 RID: 56050 RVA: 0x0006A347 File Offset: 0x00068547
			public unsafe Il2CppSystem.Action<Texture2D> callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009351 RID: 37713
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009352 RID: 37714
			private static readonly System.IntPtr NativeFieldInfoPtr_fileToFile;

			// Token: 0x04009353 RID: 37715
			private static readonly System.IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04009354 RID: 37716
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009355 RID: 37717
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009356 RID: 37718
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009357 RID: 37719
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0;

			// Token: 0x02000CC3 RID: 3267
			[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0+<<GenerateMugshot>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA2F RID: 59951 RVA: 0x003707D8 File Offset: 0x0036E9D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<<GenerateMugshot>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680529);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680530);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680531);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680532);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680533);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680534);
				}

				// Token: 0x0600EA30 RID: 59952 RVA: 0x003708B8 File Offset: 0x0036EAB8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA31 RID: 59953 RVA: 0x00370900 File Offset: 0x0036EB00
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA32 RID: 59954 RVA: 0x00370934 File Offset: 0x0036EB34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255090, XrefRangeEnd = 255105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700486F RID: 18543
				// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x00370970 File Offset: 0x0036EB70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA34 RID: 59956 RVA: 0x003709B0 File Offset: 0x0036EBB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255105, XrefRangeEnd = 255110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004870 RID: 18544
				// (get) Token: 0x0600EA35 RID: 59957 RVA: 0x003709E4 File Offset: 0x0036EBE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA36 RID: 59958 RVA: 0x00071E08 File Offset: 0x00070008
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700486C RID: 18540
				// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x00370A24 File Offset: 0x0036EC24
				// (set) Token: 0x0600EA38 RID: 59960 RVA: 0x00071E11 File Offset: 0x00070011
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700486D RID: 18541
				// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x00370A4C File Offset: 0x0036EC4C
				// (set) Token: 0x0600EA3A RID: 59962 RVA: 0x00071E2C File Offset: 0x0007002C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700486E RID: 18542
				// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x00370A7C File Offset: 0x0036EC7C
				// (set) Token: 0x0600EA3C RID: 59964 RVA: 0x00071E4B File Offset: 0x0007004B
				public unsafe MugshotGenerator.__c__DisplayClass12_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009CAF RID: 40111
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CB0 RID: 40112
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CB1 RID: 40113
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CB2 RID: 40114
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CB3 RID: 40115
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CB4 RID: 40116
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CB5 RID: 40117
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CB6 RID: 40118
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CB7 RID: 40119
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
